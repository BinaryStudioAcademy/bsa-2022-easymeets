using EasyMeets.Core.Common.DTO.Team;

namespace EasyMeets.Core.Common.DTO.Availability.AvailabilitySlotsResponse;

public class TeamSlotsDto
{
    public TeamDto Team { get; set; }
    public List<AvailabilitySlotDto> AvailabilitySlots { get; set; }
}