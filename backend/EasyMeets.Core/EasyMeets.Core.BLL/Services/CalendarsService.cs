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
        private readonly ICalendarEventService _calendarEventService;
        private readonly IGoogleMeetService _googleMeetService;
        
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IConfiguration configuration, 
            IGoogleOAuthService googleOAuthService, ICalendarEventService calendarEventService, IGoogleMeetService googleMeetService) : base(context, mapper)
        {
            _configuration = configuration;
            _userService = userService;
            _googleOAuthService = googleOAuthService;
            _calendarEventService = calendarEventService;
            _googleMeetService = googleMeetService;
        }

        public async Task<bool> CreateGoogleCalendarConnection(TokenResultDto tokenResultDto, UserDto currentUser)
        {
            var response = await HttpClientHelper.SendGetRequest<GoogleCalendarDto>($"{_configuration["GoogleCalendar:GetCalendarAPI"]}/primary", null,
                tokenResultDto.AccessToken);

            var connectedEmail = response.Id;

            if (await _context.Calendars.Where(el => el.ConnectedCalendar == connectedEmail).AnyAsync(el => el.UserId == currentUser.Id))
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
            
            await _googleMeetService.CreateDefaultCredentials(currentUser.Uid);

            var synced = await _context.SyncGoogleCalendar.FirstOrDefaultAsync(x => x.Email == connectedEmail);

            if (synced is not null)
            {
                if (DateTime.Now < synced.ExpiredDate)
                {
                    return true;
                }

                _context.SyncGoogleCalendar.Remove(synced);
                await _context.SaveChangesAsync();
            }

            await SubscribeOnCalendarChanges(tokenResultDto, connectedEmail);
            await _context.SyncGoogleCalendar.AddAsync(new SyncGoogleCalendar { Email = connectedEmail, ExpiredDate = DateTime.Now.AddDays(7) });
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

            var refreshToken = _context.Calendars.FirstOrDefault(x => x.ConnectedCalendar == email) ?? throw new Exception("Connected email don't have refresh token.");

            var tokenResultDto = await _googleOAuthService.RefreshToken(refreshToken.RefreshToken);

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

                if (calendar.AddEventsFromTeamId is not null)
                {
                    await AddMeetingsToCalendar(calendar.AddEventsFromTeamId, calendar.ConnectedCalendar);
                }

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
                await _googleMeetService.DeleteCredentials(calendar.ConnectedCalendar, calendar.UserId);
                await _googleMeetService.CreateDefaultCredentials();
                return true;
            }

            throw new ArgumentException("Calendar doesn't exist in database");
        }

        private async Task UpdateVisibleForTeamsTable(Calendar calendar, UserCalendarDto calendarDto)
        {
            _context.CalendarVisibleForTeams.RemoveRange(calendar.VisibleForTeams);
            await RemoveCalendarMeetings(calendar.VisibleForTeams, calendar.Id);

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
                await AddMeetingsFromCalendar(calendar.ConnectedCalendar, calendar.VisibleForTeams, calendar.Id);
            }
        }

        public async Task<bool> SyncChangesFromGoogleCalendar(string email)
        {
            var calendars = await _context.Calendars.Where(x => x.ConnectedCalendar == email).ToListAsync();

            if (!calendars.Any())
            {
                return false;
            }

            foreach (var calendar in calendars)
            {
                var visibleCalendar = await _context.CalendarVisibleForTeams.Where(x => x.CalendarId == calendar.Id).ToListAsync();

                await RemoveCalendarMeetings(visibleCalendar, calendar.Id);
                await AddMeetingsFromCalendar(email, calendar.VisibleForTeams, calendar.Id);
            }

            return true;
        }

        private async Task RemoveCalendarMeetings(IEnumerable<CalendarVisibleForTeam> visibleCalendar, long calendarId)
        {
            foreach (var item in visibleCalendar.ToList())
            {
                await _calendarEventService.RemoveCalendarEvents(calendarId);
            }
        }

        private async Task AddMeetingsFromCalendar(string email, IEnumerable<CalendarVisibleForTeam> visibleCalendar, long calendarId)
        {
            var events = await GetEventsFromGoogleCalendar(email);

            foreach (var item in visibleCalendar.ToList())
            {
                await _calendarEventService.AddCalendarEvents(events, calendarId);
            }
        }
        private async Task AddMeetingsToCalendar(long? teamId, string email)
        {
            var meetings = await _context.Meetings.Where(x => x.TeamId == teamId).ToListAsync();

            var refreshToken = _context.Calendars.FirstOrDefault(x => x.ConnectedCalendar == email) ?? throw new Exception("Connected email don't have refresh token.");

            var tokenResultDto = await _googleOAuthService.RefreshToken(refreshToken.RefreshToken);

            if (meetings.Any())
            {
                foreach (var item in meetings)
                {
                    await AddMeetingToCalendar(item, tokenResultDto);
                }
            }
        }

        private async Task AddMeetingToCalendar(Meeting meeting, TokenResultDto tokenResultDto)
        {
            var queryParams = new Dictionary<string, string>
            {
                { "calendarId", "primary" }
            };

            var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == meeting.CreatedBy) ?? throw new Exception("Meeting doesnt have owner.");

            var starttime = meeting.StartTime.DateTime.ToString("yyyy-MM-dd HH:mm").Replace(" ", "T") + ":00" + currentUser.TimeZoneValue;
            var endtime = meeting.StartTime.DateTime.AddMinutes(meeting.Duration).ToString("yyyy-MM-dd HH:mm").Replace(" ", "T") + ":00" + currentUser.TimeZoneValue;

            var body = new
            {
                summary = meeting.Name,
                status = "confirmed",
                end = new
                {
                    dateTime = DateTime.Parse(endtime)
                },
                start = new
                {
                    dateTime = DateTime.Parse(starttime)
                }
            };

            await HttpClientHelper.SendPostTokenRequest<SubscribeEventDTO>($"https://www.googleapis.com/calendar/v3/calendars/calendarId/events", queryParams, body,
                tokenResultDto.AccessToken);
        }
    }
}