using System.Security.Claims;
using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Context;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Http;

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
                        GetCurrentUserEmail(), 
                        CancellationToken.None,
                        null);
            var t = credential.Token.AccessToken;
            
            return true;
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