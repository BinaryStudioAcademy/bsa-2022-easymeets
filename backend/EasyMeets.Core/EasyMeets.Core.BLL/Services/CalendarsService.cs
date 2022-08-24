using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services
{
    public class CalendarsService : BaseService, ICalendarsService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private const string ApplicationName = "EasyMeets";
        private CalendarService _service = new();
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IConfiguration configuration) : base(context, mapper)
        {
            _userService = userService;
            _configuration = configuration;
        }

        public async Task<bool> CreateGoogleCalendarConnection()
        {
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        new ClientSecrets
                        {
                            ClientId = _configuration["GoogleCalendar:client_id"],
                            ClientSecret = _configuration["GoogleCalendar:client_secret"]
                        }, 
                        new [] { CalendarService.Scope.Calendar },
                        Guid.NewGuid().ToString(), 
                        CancellationToken.None,
                        null);

            _service = new CalendarService(new BaseClientService.Initializer{
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            var calendars = await _service.CalendarList.List().ExecuteAsync();

            var connectedEmail = calendars.Items.FirstOrDefault(el => el.Primary == true)?.Id;

            if (await _context.Calendars.AnyAsync(el => el.ConnectedCalendar == connectedEmail))
            {
                throw new ArgumentException($"Calendar {connectedEmail} is already connected!");
            }
            
            var currentUser = await _userService.GetCurrentUserAsync();
            
            var calendar = new Calendar
            {
                UserId = currentUser.Id,
                CheckForConflicts = false,
                ConnectedCalendar = connectedEmail!,
                AccessToken = credential.Token.AccessToken,
                RefreshToken = credential.Token.RefreshToken,
                Uid = credential.UserId,
                CreatedBy = currentUser.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Calendars.Add(calendar);
            await _context.SaveChangesAsync();
            
            return true;
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

            if (calendar != null)
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

            if (newVisibleForList != null)
            {
                calendar.VisibleForTeams = newVisibleForList;
                await _context.CalendarVisibleForTeams.AddRangeAsync(newVisibleForList);
            }
        }
    }
}