using System.Security.Claims;
using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Context;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
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
            var currentUserEmail = GetCurrentUserEmail();
            
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        new ClientSecrets
                        {
                            ClientId = credentialsDto.ClientId,
                            ClientSecret = credentialsDto.ClientSecret
                        }, 
                        new [] { CalendarService.Scope.Calendar },
                        currentUserEmail, 
                        CancellationToken.None,
                        null);

            var currentUser = await _context.Users.FirstAsync(el => el.Email == currentUserEmail);

            var calendar = new DAL.Entities.Calendar
            {
                UserId = currentUser.Id,
                CheckForConflicts = false,
                ConnectedCalendar = credential.UserId,
                AccessToken = credential.Token.AccessToken,
                RefreshToken = credential.Token.RefreshToken,
                CreatedBy = currentUser.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Calendars.Add(calendar);
            await _context.SaveChangesAsync();
            
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

        public async Task<Calendar> CreateCalendar()
        {
            var eventRequest = _service.Calendars.Insert(new Calendar()
            {
                Description = "Description",
                TimeZone = "America/Los_Angeles",
                Summary = "Just nice calendar"
            });

            var c = await eventRequest.ExecuteAsync();

            c.Id = ApplicationName;

            return c;
        }
        
        public string GetCurrentUserEmail()
        {
            var claimsList = _httpContextAccessor.HttpContext!.User.Claims.ToList();
            var email = claimsList.Find(el => el.Type == ClaimTypes.Email);
            return email!.Value;
        }
    }
}