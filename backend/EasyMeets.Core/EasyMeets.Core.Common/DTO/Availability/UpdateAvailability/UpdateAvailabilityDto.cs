namespace EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;

public class UpdateAvailabilityDto
{
    public GeneralDetailsUpdateDto GeneralDetailsUpdate { get; set; }
    public EventDetailsUpdateDto EventDetailsUpdate { get; set; }
    public bool HasAdvancedSettings { get; set; }
    public bool IsActive { get; set; }
}