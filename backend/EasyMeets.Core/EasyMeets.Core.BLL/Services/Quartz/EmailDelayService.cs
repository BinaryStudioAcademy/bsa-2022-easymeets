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
            var emailTemplates = await _context.EmailTemplates
                .Where(x => x.TemplateType == templateType && x.IsSend && x.TimeValue != string.Empty)
                .Include(x => x.AvailabilitySlot)
                .ToListAsync();

            await Notify(emailTemplates);
        }

        public async Task Notify(List<EmailTemplate> templates)
        {
            foreach (var emailTemplate in templates)
            {
                var slot = emailTemplate.AvailabilitySlot;

                if (slot.Meetings is null || !slot.Meetings.Any())
                {
                    break;
                }

                double minutes = TimeSpan.Parse(emailTemplate.TimeValue).TotalMinutes;

                if (emailTemplate.TemplateType == TemplateType.Reminders)
                {
                    minutes *= -1;
                }

                await Task.WhenAll(slot.Meetings.Select(x => CheckAndSend(minutes, x, emailTemplate)));
            }
        }

        public async Task CheckAndSend(double minutes, Meeting meeting, EmailTemplate emailTemplate)
        {
            if (meeting.StartTime.AddMinutes(minutes) == DateTimeOffset.Now)
            {
                try
                {
                    await _meetingService.SendEmailsAsync(meeting.Id, emailTemplate.TemplateType);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error in Quartz worker. Error : {ex.Message}");
                }
                finally
                {
                    _context.EmailTemplates.Remove(emailTemplate);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
