using System.Security.Claims;
using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class CalendarsService : BaseService, ICalendarsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string ApplicationName = "EasyMeets";
        private CalendarService _service = new();
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> CreateGoogleCalendarConnection(UserCredentialsDto credentialsDto)
        {
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        new ClientSecrets
                        {
                            ClientId = credentialsDto.ClientId,
                            ClientSecret = credentialsDto.ClientSecret
                        }, 
                        new [] { CalendarService.Scope.Calendar },
                        Guid.NewGuid().ToString(), 
                        CancellationToken.None,
                        null);
            
            _service = new CalendarService(new BaseClientService.Initializer(){
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            var calendars = await _service.CalendarList.List().ExecuteAsync();

            var connectedEmail = calendars.Items.FirstOrDefault(el => el.Primary == true)?.Id;
            
            var calendarExist = await _context.Calendars.FirstOrDefaultAsync(el => el.ConnectedCalendar == connectedEmail);
            
            if (calendarExist != null)
            {
                return false;
            }
            
            var currentUser = await _context.Users.FirstAsync(el => el.Email == GetCurrentUserEmail());
            
            var calendar = new DAL.Entities.Calendar
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

                if (calendar == null)
                {
                    return false;
                }

                foreach (var visibleFor in calendar.VisibleForTeams.ToList())
                {
                    _context.CalendarVisibleForTeams.Remove(visibleFor);
                    calendar.VisibleForTeams.Remove(visibleFor);
                }

                var newVisibleForList = calendarDto.VisibleForTeams?.Select(el =>
                {
                    return new CalendarVisibleForTeam()
                    {
                        CalendarId = calendar.Id,
                        TeamId = el.Id,
                        IsDeleted = false,
                    };
                }).ToList();

                if (newVisibleForList != null)
                {
                    calendar.VisibleForTeams = newVisibleForList;
                    await _context.CalendarVisibleForTeams.AddRangeAsync(newVisibleForList);
                }

                calendar.CheckForConflicts = calendarDto.CheckForConflicts;
                calendar.AddEventsFromTeamId = calendarDto.ImportEventsFromTeam?.Id;
            
                _context.Calendars.Update(calendar);
                await _context.SaveChangesAsync();
            }
            
            return true;
        }

        public async Task<List<UserCalendarDto>> GetCurrentUserCalendars()
        {
            var currentUserEmail = GetCurrentUserEmail();
            var currentUser = await _context.Users.FirstAsync(el => el.Email == currentUserEmail);
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

            return false;
        }

        private string GetCurrentUserEmail()
        {
            var claimsList = _httpContextAccessor.HttpContext!.User.Claims.ToList();
            var email = claimsList.Find(el => el.Type == ClaimTypes.Email);
            return email!.Value;
        }
    }
}