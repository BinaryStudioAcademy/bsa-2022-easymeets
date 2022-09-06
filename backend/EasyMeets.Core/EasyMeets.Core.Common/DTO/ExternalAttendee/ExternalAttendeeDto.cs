namespace EasyMeets.Core.Common.DTO.ExternalAttendee;

public class ExternalAttendeeDto
{
    public long AvailabilitySlotId { get; set; }
    public long MeetingId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string TimeZoneName { get; set; } = string.Empty;
    public string TimeZoneValue { get; set; } = string.Empty;
}