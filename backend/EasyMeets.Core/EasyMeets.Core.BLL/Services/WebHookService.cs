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
        public WebHookService(EasyMeetsCoreContext context, IMapper mapper, IConfiguration configuration, 
            ICalendarsService calendarService) : base(context, mapper)
        {
            _configuration = configuration;
            _calendarService = calendarService;
        }

        public async Task GetNofiticationCalendarEvents(string email)
        {

            var events = await _calendarService.GetEventsFromGoogleCalendar(email);


        }
    }
}
