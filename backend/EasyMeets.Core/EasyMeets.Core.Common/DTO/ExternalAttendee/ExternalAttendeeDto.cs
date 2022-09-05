using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.ExternalAttendee;

public class ExternalAttendeeDto : TimeZoneDto
{
    public long AvailabilitySlotId { get; set; }
    public long MeetingId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}