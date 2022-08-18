using EasyMeets.Core.Common.DTO.Availability.Schedule;

namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class NewAvailabilitySlotDto
{
    public long CreatedBy { get; set; }
    public long TeamId { get; set; }
    public bool HasAdvancedSettings { get; set; }
    public GeneralDetailsDto? GeneralDetails { get; set; }
    public EventDetailsDto? EventDetails { get; set; }
    public NewAdvancedSlotSettingsDto? AdvancedSettings { get; set; }
    public ScheduleDto Schedule { get; set; } = null!;
}