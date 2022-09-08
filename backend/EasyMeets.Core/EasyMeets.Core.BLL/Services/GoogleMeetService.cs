using AutoMapper;
using EasyMeets.Core.BLL.Helpers;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.Credentials.GoogleMeet;
using EasyMeets.Core.Common.DTO.GoogleMeet;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services;

public class GoogleMeetService : BaseService, IGoogleMeetService
{
    private readonly IGoogleOAuthService _googleOAuthService;
    private readonly IConfiguration _configuration;
    private readonly IUserService _userService;
    public GoogleMeetService(EasyMeetsCoreContext context, IMapper mapper, IGoogleOAuthService googleOAuthService, IConfiguration configuration, IUserService userService) : base(context, mapper)
    {
        _googleOAuthService = googleOAuthService;
        _configuration = configuration;
        _userService = userService;
    }

    public async Task<List<MeetCredentialsDto>> GetAvailableEmails()
    {
        var userId = _userService.GetCurrentUserId();
        return await _context.Calendars
            .Include(c => c.User)
            .Where(c => c.User.Uid == userId)
            .Select(c => new MeetCredentialsDto
            {
                UserEmail = c.ConnectedCalendar
            }).ToListAsync();
    }

    public async Task CreateMeetCredentials(MeetCredentialsDto credentialsDto)
    {
        var user = await _context.Users
                       .Include(u => u.Credentials)
                       .FirstOrDefaultAsync(u => u.Uid == _userService.GetCurrentUserId()) 
                   ?? throw new KeyNotFoundException("User doesn't exist");
        if (user.Credentials.Any(cr => cr.Type == CredentialsType.Meet))
        {
            var credentials = user.Credentials.First(cr => cr.Type == CredentialsType.Meet);
            _mapper.Map(credentialsDto, credentials);
        }
        else
        { 
            var credentials = _mapper.Map<Credentials>(credentialsDto, opts =>
                opts.AfterMap((_, dest) => dest.UserId = user.Id));
            await _context.Credentials.AddAsync(credentials);
            
        }
        await _context.SaveChangesAsync();
    }

    public async Task CreateGoogleMeet(long meetingId)
    {
        var meeting = await _context.Meetings
            .Include(m => m.Author)
                .ThenInclude(a => a.Credentials)
            .FirstOrDefaultAsync(m => m.Id == meetingId) ?? throw new KeyNotFoundException("Invalid meeting id");

        var credentials = meeting.Author.Credentials.FirstOrDefault(c => c.Type == CredentialsType.Meet)
                          ?? throw new KeyNotFoundException("No meet credentials found");

        var calendar = _context.Calendars.FirstOrDefault(x => x.ConnectedCalendar == credentials.UserEmail)
                       ?? throw new KeyNotFoundException("No calendar found for specified email");
        
        var token = await _googleOAuthService.RefreshToken(calendar.RefreshToken);

        var createdMeeting = await CreateEventWithMeeting(meeting, token);
        
        meeting.MeetingLink = createdMeeting.ConferenceData.EntryPoints.First().Uri;

        await _context.SaveChangesAsync();
    }

    private Task<MeetResponseDto> CreateEventWithMeeting(Meeting meeting, TokenResultDto token)
    {
        var queryParams = new Dictionary<string, string>
        {
            { "calendarId", "primary" },
            { "conferenceDataVersion", "1"}
        };

        var start = meeting.StartTime.DateTime.ToString("yyyy-MM-dd HH:mm").Replace(" ", "T") + ":00" + meeting.Author.TimeZoneValue;
        var end = meeting.StartTime.DateTime.AddMinutes(meeting.Duration).ToString("yyyy-MM-dd HH:mm").Replace(" ", "T") + ":00" + meeting.Author.TimeZoneValue;

        var body = new EventWithMeetDto
        {
            Summary = meeting.Name,
            Start = new EventTimeDto
            {
                DateTime = DateTime.Parse(start)
            },
            End = new EventTimeDto
            {
                DateTime = DateTime.Parse(end)
            }
        };

        return HttpClientHelper.SendPostTokenRequest<MeetResponseDto>(_configuration["GoogleCalendar:GetEventsFromGoogleCalendar"],
            queryParams, body, token.AccessToken);
    }
}