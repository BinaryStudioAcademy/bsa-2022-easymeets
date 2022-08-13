namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class NewAvailabilitySlotDto
{
    public GeneralDetailsDto? GeneralDetails { get; set; }
    public EventDetailsDto? EventDetails { get; set; }
    public NewAdvancedSlotSettingsDto? AdvancedSettings { get; set; }
}