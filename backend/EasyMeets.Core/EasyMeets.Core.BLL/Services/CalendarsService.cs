using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using Google.Apis.Auth.AspNetCore3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.BLL.Services
{
    public class CalendarsService : BaseService, ICalendarsService
    {
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<string> GetCalendar(IGoogleAuthProvider auth)
        {
            GoogleCredential cred = await auth.GetCredentialAsync();
            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred,
                ApplicationName = "EasyMeets"
            });

            var calendarsList = await service.CalendarList.List().ExecuteAsync();
            return calendarsList.Items[0].Description;
        }
    }
}