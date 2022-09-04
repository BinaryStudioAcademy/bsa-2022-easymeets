using AutoMapper;
using EasyMeets.Core.BLL.Helpers;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services
{
    public class CalendarsService : BaseService, ICalendarsService
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IGoogleOAuthService _googleOAuthService;
        private readonly IMeetingService _meetingService;
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IConfiguration configuration, 
            IGoogleOAuthService googleOAuthService, IMeetingService meetingService) : base(context, mapper)
        {
            _configuration = configuration;
            _userService = userService;
            _googleOAuthService = googleOAuthService;
            _meetingService = meetingService;
        }

        public async Task<bool> CreateGoogleCalendarConnection(TokenResultDto tokenResultDto, UserDto currentUser)
        {
            var response = await HttpClientHelper.SendGetRequest<GoogleCalendarDto>($"{_configuration["GoogleCalendar:GetCalendarAPI"]}/primary", null,
                tokenResultDto.AccessToken);

            var connectedEmail = response.Id;

            if (await _context.Calendars.AnyAsync(el => el.ConnectedCalendar == connectedEmail))
            {
                throw new ArgumentException($"Calendar {connectedEmail} is already connected!");
            }

            var calendar = new Calendar
            {
                UserId = currentUser.Id,
                CheckForConflicts = false,
                ConnectedCalendar = connectedEmail,
                AccessToken = tokenResultDto.AccessToken,
                RefreshToken = tokenResultDto.RefreshToken,
                Uid = Environment.GetEnvironmentVariable("codeVerifier")!,
                CreatedBy = currentUser.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Calendars.Add(calendar);
            await _context.SaveChangesAsync();

            var synced = await _context.SyncGoogleCalendar.Where(x => x.Email == connectedEmail).FirstOrDefaultAsync();

            if (synced is not null)
            {
                return true;
            }

            await SubscribeOnCalendarChanges(tokenResultDto, connectedEmail);
            await _context.SyncGoogleCalendar.AddAsync(new SyncGoogleCalendar { Email = connectedEmail });
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task SubscribeOnCalendarChanges(TokenResultDto tokenResultDto, string connectedEmail)
        {
            var queryParams = new Dictionary<string, string>
            {
                { "calendarId", "primary" }
            };

            var emailName = connectedEmail.Split('@')[0];

            var body = new
            {
                id = emailName,
                type = "web_hook",
                address = _configuration["GoogleCalendar:WebHookCalendarUrl"]
            };

            await HttpClientHelper.SendPostTokenRequest<SubscribeEventDTO>($"{_configuration["GoogleCalendar:SubscribeOnEventsCalendar"]}", queryParams, body,
                tokenResultDto.AccessToken);
        }

        public async Task<List<EventItemDTO>> GetEventsFromGoogleCalendar(string email)
        {
            var queryParams = new Dictionary<string, string>
            {
                { "calendarId", email }
            };

            var refreshToken = _context.Calendars.Where(x => x.ConnectedCalendar == email).FirstOrDefault()!.RefreshToken;

            var tokenResultDto = await _googleOAuthService.RefreshToken(refreshToken);

            var response = await HttpClientHelper.SendGetRequest<CalendarEventsDTO>($"{_configuration["GoogleCalendar:GetEventsFromGoogleCalendar"]}", queryParams,
                tokenResultDto.AccessToken);

            if (response.Items is null)
            {
                return new List<EventItemDTO>();
            }

            var events = response.Items.Where(x => x.Start is not null && x.End is not null && x.Start.DateTime > DateTime.Now).ToList();

            return events;
        }

        public async Task<bool> UpdateGoogleCalendar(List<UserCalendarDto> calendarDtoList)
        {
            foreach (var calendarDto in calendarDtoList)
            {
                var calendar = await _context.Calendars
                    .Include(c => c.ImportEventsFromTeam)
                    .Include(c => c.VisibleForTeams)
                    .FirstOrDefaultAsync(el => el.Id == calendarDto.Id);

                await UpdateVisibleForTeamsTable(calendar!, calendarDto);

                calendar!.CheckForConflicts = calendarDto.CheckForConflicts;
                calendar.AddEventsFromTeamId = calendarDto.ImportEventsFromTeam?.Id;

                _context.Calendars.Update(calendar);
                await _context.SaveChangesAsync();
            }

            return true;
        }

        public async Task<List<UserCalendarDto>> GetCurrentUserCalendars()
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var calendarsList = await _context.Calendars
                .Where(c => c.UserId == currentUser.Id)
                .Include(c => c.User)
                .Include(c => c.ImportEventsFromTeam)
                .Include(c => c.VisibleForTeams)
                    .ThenInclude(v => v.Team)
                .ToListAsync();

            return _mapper.Map<List<UserCalendarDto>>(calendarsList);
        }

        public async Task<bool> DeleteCalendar(long id)
        {
            var calendar = await _context.Calendars
                .Include(el => el.VisibleForTeams)
                .FirstOrDefaultAsync(el => el.Id == id);

            if (calendar is not null)
            {
                _context.Calendars.Remove(calendar);
                await _context.SaveChangesAsync();
                return true;
            }

            throw new ArgumentException("Calendar doesn't exist in database");
        }

        private async Task UpdateVisibleForTeamsTable(Calendar calendar, UserCalendarDto calendarDto)
        {
            _context.CalendarVisibleForTeams.RemoveRange(calendar!.VisibleForTeams);

            foreach (var item in calendar.VisibleForTeams)
            {
                await _meetingService.DeleteGoogleCalendarMeetings(item.TeamId);
            }

            calendar.VisibleForTeams = Array.Empty<CalendarVisibleForTeam>();

            var newVisibleForList = calendarDto.VisibleForTeams?
                .Select(el => new CalendarVisibleForTeam
                {
                    CalendarId = calendar.Id,
                    TeamId = el.Id,
                    IsDeleted = false,
                }).ToList();

            if (newVisibleForList is not null)
            {
                calendar.VisibleForTeams = newVisibleForList;
                await _context.CalendarVisibleForTeams.AddRangeAsync(newVisibleForList);

                var events = await GetEventsFromGoogleCalendar(calendar.ConnectedCalendar);

                foreach (var item in calendar.VisibleForTeams)
                {
                    await _meetingService.AddGoogleCalendarMeetings(item.TeamId, events, calendar.UserId);
                }
            }
        }

        public async Task<bool> SyncChangesFromGoogleCalendar(string email)
        {
            var calendar = await _context.Calendars.Where(x => x.ConnectedCalendar == email).FirstOrDefaultAsync();

            if (calendar is null)
            {
                return false;
            }

            var visibleCalendar = await _context.CalendarVisibleForTeams.Where(x => x.CalendarId == calendar.Id).ToListAsync();

            foreach (var item in visibleCalendar)
            {
                await _meetingService.DeleteGoogleCalendarMeetings(item.TeamId);
            }

            var events = await GetEventsFromGoogleCalendar(email);

            foreach (var item in calendar.VisibleForTeams)
            {
                await _meetingService.AddGoogleCalendarMeetings(item.TeamId, events, calendar.UserId);
            }

            return true;
        }
    }
}