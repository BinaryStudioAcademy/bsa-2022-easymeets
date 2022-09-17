using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

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
            var avslots = _context.AvailabilitySlots.ToList();

            await NotifyFollowUp(avslots);
            await NotifyReminders(avslots);

            await Task.CompletedTask;
        }

        public async Task NotifyReminders(List<AvailabilitySlot> slots)
        {
            var notifiers = await _context.EmailTemplates.Where(x => x.Subject == "Reminders Email" && x.IsSend == true && x.TimeValue != string.Empty).ToListAsync();

            foreach (var emailTemplate in notifiers)
            {
                var slot = slots.FirstOrDefault(x => x.Id == emailTemplate.AvailabilitySlotId);

                if (slot is null || slot.Meetings is null)
                {
                    break;
                }

                foreach (var meeting in slot.Meetings)
                {
                    double minutes = TimeSpan.Parse(emailTemplate.TimeValue).TotalMinutes * -1;

                    if (meeting.StartTime.AddMinutes(minutes) == DateTimeOffset.Now)
                    {
                        await _meetingService.SendEmailsAsync(meeting.Id, TemplateType.Reminders);
                    }
                }
            }
        }

        public async Task NotifyFollowUp(List<AvailabilitySlot> slots)
        {
            var followUps = await _context.EmailTemplates.Where(x => x.Subject == "Follow-Up Email" && x.IsSend == true && x.TimeValue != string.Empty).ToListAsync();

            foreach (var emailTemplate in followUps)
            {
                var slot = slots.FirstOrDefault(x => x.Id == emailTemplate.AvailabilitySlotId);

                if (slot is null || slot.Meetings is null)
                {
                    break;
                }

                foreach (var meeting in slot.Meetings)
                {
                    double minutes = TimeSpan.Parse(emailTemplate.TimeValue).TotalMinutes;

                    if (meeting.StartTime.AddMinutes(minutes) == DateTimeOffset.Now)
                    {
                        await _meetingService.SendEmailsAsync(meeting.Id, TemplateType.FollowUp);
                    }
                }
            }
        }
    }
}
