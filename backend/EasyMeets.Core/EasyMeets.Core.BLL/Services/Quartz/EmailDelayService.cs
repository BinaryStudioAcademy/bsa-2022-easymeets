using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Services.Quartz
{
    public class EmailDelayService : BaseService, IEmailDelayService
    {
        public EmailDelayService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public void FillSyncGoogleCalendars()
        {
            SyncGoogleCalendar syncGoogleCalendar = new SyncGoogleCalendar();
            syncGoogleCalendar.Email = "olol@asdl.com";
            syncGoogleCalendar.ExpiredDate = DateTime.Now;

            _context.SyncGoogleCalendar.Add(syncGoogleCalendar);
            _context.SaveChanges();
        }
    }
}
