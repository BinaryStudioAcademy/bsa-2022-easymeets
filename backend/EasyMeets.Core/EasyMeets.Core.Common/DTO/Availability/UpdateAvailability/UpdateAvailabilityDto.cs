namespace EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;

public class UpdateAvailabilityDto
{
    public GeneralDetailsUpdateDto GeneralDetailsUpdate { get; set; } = null!;
    public EventDetailsUpdateDto EventDetailsUpdate { get; set; } = null!;
    public bool HasAdvancedSettings { get; set; }
    public bool IsActive { get; set; }
}