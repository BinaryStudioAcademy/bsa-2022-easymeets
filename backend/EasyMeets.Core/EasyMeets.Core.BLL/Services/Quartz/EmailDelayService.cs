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

        public async Task CheckForNotify(TemplateType templateType)
        {
            var slots = await _context.EmailTemplates
                .Where(x => x.TemplateType == templateType && x.IsSend && x.TimeValue != string.Empty)
                .Include(x => x.AvailabilitySlot)
                .Select(x => x.AvailabilitySlot)
                .ToListAsync();

            await Notify(slots, templateType);
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

                if (templateType == TemplateType.Reminders)
                {
                    minutes *= -1;
                }

                await Task.WhenAll(slot.Meetings.Select(x => CheckAndSend(minutes, x, templateType)));
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
