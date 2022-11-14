using AutoMapper;
using EasyMeets.Core.BLL.Extensions;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services.Quartz
{
    public class EmailDelayService : BaseService, IEmailDelayService
    {
        private readonly IMeetingService _meetingService;

        public EmailDelayService(EasyMeetsCoreContext context, IMapper mapper, IMeetingService meetingService) : base(context, mapper)
        {
            _meetingService = meetingService;
        }

        public async Task CheckForNotify(TemplateType templateType, DateTime lastSentTime)
        {
            var format = "MM/dd/yyyy hh:mm";

            do
            {
                var meetings = await _context.Meetings
                    .Include(m => m.AvailabilitySlot)
                        .ThenInclude(y => y.EmailTemplates)
                    .Where(x =>
                        x.AvailabilitySlot != null &&
                        x.AvailabilitySlot.EmailTemplates.Any(x => x.TemplateType == templateType && x.IsSend && x.TimeValue != string.Empty))
                    .ToListAsync();

                var meetingsForSending = meetings //Separated because TimeSpan.Parse is impossible to use in LINQ to DB query
                    .Where(x => 
                        x.StartTime.AddMinutes(
                            -TimeSpan.Parse(x.AvailabilitySlot!.EmailTemplates.FirstOrDefault(x => x.TemplateType == templateType)!.TimeValue).TotalMinutes
                            ).DateTime.Format(format) == lastSentTime.Format(format))
                    .ToList();

                if (meetingsForSending.Any())
                {
                    meetingsForSending.Select(async meeting => await _meetingService.SendEmailsAsync(meeting.Id, templateType));
                }

                lastSentTime = lastSentTime.AddMinutes(1);
            }
            while (lastSentTime.Format(format) < DateTime.UtcNow.Format(format));
        }
    }
}
