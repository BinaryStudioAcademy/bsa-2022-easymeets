using AutoMapper;
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

        public async Task CheckForNotify(TemplateType templateType)
        {
            var meetings = await _context.Meetings.Where(x => x.AvailabilitySlot != null && x.AvailabilitySlot.EmailTemplates.Any(x => x.TemplateType == templateType && x.IsSend && x.TimeValue != string.Empty))
                .Where(meeting => 
                TimeSpan.Parse(meeting.StartTime.AddMinutes(TimeSpan.Parse(meeting.AvailabilitySlot!.EmailTemplates.FirstOrDefault(x => x.TemplateType == templateType)!.TimeValue).TotalMinutes).ToString("MM/dd/yyyy hh:mm")) 
                == TimeSpan.Parse(DateTimeOffset.Now.ToString("MM/dd/yyyy hh:mm")))
                .ToListAsync();

            if (meetings.Any())
            {
                await Task.WhenAll(meetings.Select(meeting => _meetingService.SendEmailsAsync(meeting.Id, templateType)));
            }
        }
    }
}
