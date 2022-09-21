using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.SaveAvailability;

public class SaveAvailabilitySlotDto
{
    public long? TeamId { get; set; }
    public bool HasAdvancedSettings { get; set; }
    public GeneralDetailsDto? GeneralDetails { get; set; }
    public EventDetailsDto? EventDetails { get; set; }
    public List<SlotMemberDto> SlotMembers { get; set; } = new();
    public ScheduleDto? Schedule { get; set; }
    public SaveAdvancedSlotSettingsDto? AdvancedSettings { get; set; }
    public ICollection<QuestionDto>? Questions { get; set; }
    public ICollection<EmailTemplatesSettingsDto>? TemplateSettings { get; set; }
    public ParticipationRule ParticipationRule { get; set; }
}