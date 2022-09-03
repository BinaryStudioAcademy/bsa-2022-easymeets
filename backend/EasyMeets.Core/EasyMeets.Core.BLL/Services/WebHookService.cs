using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services
{
    public class WebHookService : BaseService, IWebHookService
    {
        private readonly IConfiguration _configuration;
        private readonly ICalendarsService _calendarService;
        private readonly IGoogleOAuthService _googleOAuthService;
        public WebHookService(EasyMeetsCoreContext context, IMapper mapper, IConfiguration configuration, 
            ICalendarsService calendarService, IGoogleOAuthService googleOAuthService) : base(context, mapper)
        {
            _configuration = configuration;
            _calendarService = calendarService;
            _googleOAuthService = googleOAuthService;
        }

        public async Task GetNofiticationCalendarEvents(string email)
        {
            var refreshToken = _context.Calendars.Where(x => x.ConnectedCalendar == email).FirstOrDefault()!.RefreshToken;

            var tokenResultDto = await _googleOAuthService.RefreshToken(refreshToken);

            var events = await _calendarService.GetEventsFromGoogleCalendar(tokenResultDto, email);


        }
    }
}
