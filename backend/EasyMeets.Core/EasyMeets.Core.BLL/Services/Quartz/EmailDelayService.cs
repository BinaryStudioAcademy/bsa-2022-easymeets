using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
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

        public async Task CheckForNotify()
        {
            var slots = await _context.EmailTemplates
                .Where(x => (x.TemplateType == TemplateType.Reminders && x.IsSend == true) || (x.TemplateType == TemplateType.FollowUp && x.IsSend == true))
                .Include(x => x.AvailabilitySlot)
                .Select(x => x.AvailabilitySlot).ToListAsync();

            await Notify(slots, TemplateType.Reminders);
            await Notify(slots, TemplateType.FollowUp);

            await Task.CompletedTask;
        }

        public async Task Notify(List<AvailabilitySlot> slots, TemplateType templateType)
        {
            var templates = await _context.EmailTemplates.Where(x => x.TemplateType == templateType && x.IsSend == true && x.TimeValue != string.Empty).ToListAsync();

            foreach (var emailTemplate in templates)
            {
                var slot = slots.FirstOrDefault(x => x.Id == emailTemplate.AvailabilitySlotId);

                if (slot is null || slot.Meetings is null)
                {
                    break;
                }

                double minutes = TimeSpan.Parse(emailTemplate.TimeValue).TotalMinutes;

                if(templateType == TemplateType.Reminders)
                {
                    minutes *= -1;
                }

                _ = slot.Meetings.Select(async x => await CheckAndSend(minutes, x, templateType));
            }
        }

        public async Task CheckAndSend(double minutes, Meeting meeting, TemplateType templateType)
        {
            if (meeting.StartTime.AddMinutes(minutes) == DateTimeOffset.Now)
            {
                await _meetingService.SendEmailsAsync(meeting.Id, templateType);
            }
        }
    }
}
