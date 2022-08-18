namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class NewAvailabilitySlotDto
{
    public long TeamId { get; set; }
    public bool HasAdvancedSettings { get; set; }
    public GeneralDetailsDto? GeneralDetails { get; set; }
    public EventDetailsDto? EventDetails { get; set; }
    public NewAdvancedSlotSettingsDto? AdvancedSettings { get; set; }
    public NewScheduleDto Schedule { get; set; }
}