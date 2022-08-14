using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.Common.DTO.Availability.AvailabilitySlotsResponse;

public class AuthorSlotsDto
{
    public UserDto Author { get; set; }
    public List<AvailabilitySlotDto> AvailabilitySlots { get; set; }
}