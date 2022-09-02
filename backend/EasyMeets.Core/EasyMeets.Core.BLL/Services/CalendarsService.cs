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
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IConfiguration configuration) : base(context, mapper)
        {
            _configuration = configuration;
            _userService = userService;
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
            
            return true;
        }

        public async Task<string> SubscribeOnCalendarChanges(TokenResultDto tokenResultDto)
        {
            var queryParams = new Dictionary<string, string>
            {
                { "calendarId", "primary" }
            };

            var body = new
            {
                id = "qazwsxsad",
                type = "web_hook",
                address = "https://webhook.site/179c5683-f398-4efc-8ce6-24e7ddd953b5"
            };

            var response = await HttpClientHelper.SendPostTokenRequest<SubscribeEventDTO>($"{_configuration["GoogleCalendar:SubscribeOnEventsCalendar"]}", queryParams, body,
                tokenResultDto.AccessToken);

            var checkResult = response.Id;

            return checkResult;
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
            }
        }
    }
}