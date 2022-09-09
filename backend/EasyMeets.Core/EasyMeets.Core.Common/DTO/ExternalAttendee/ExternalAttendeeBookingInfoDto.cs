using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.Common.DTO.ExternalAttendee;

public class ExternalAttendeeBookingInfoDto
{
    public ExternalUserDto? User { get; set; }
    public List<ExternalAvailabilitySlotDto>? PersonalSlots { get; set; }
}