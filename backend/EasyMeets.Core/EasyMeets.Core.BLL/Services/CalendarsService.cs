using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Context;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace EasyMeets.Core.BLL.Services
{
    public class CalendarsService : BaseService, ICalendarsService
    {
        public CalendarsService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Event> CreateCalendar(GoogleCalendarDto request)
        {
            string[] scopes = { "https://www.googleapis.com/auth/calendar" };
            string applicationName = "EasyMeets";
            UserCredential userCredential;
            using (var stream = new FileStream(Path.Combine(@"D:\Programming\bsa\project-2\bsa-2022-easymeets\backend\EasyMeets.Core\EasyMeets.Core.WebAPI\Credentials\credentials.json"), FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                userCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)
                    ).Result;
            }

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = userCredential,
                ApplicationName = applicationName
            });

            Event ev = new Event()
            {
                Summary = request.Summary,
                Location = request.Location,
                Start = new EventDateTime()
                {
                    DateTime = request.Start,
                    TimeZone = "Asia/Ho_Chi_Minh"
                },
                End = new EventDateTime()
                {
                    DateTime = request.End,
                    TimeZone = "Asia/Ho_Chi_Minh"
                },
                Description = request.Description
            };

            var eventRequest = service.Events.Insert(ev, "primary");
            var requestCreate = await eventRequest.ExecuteAsync();
            
            return requestCreate;
        }
    }
}