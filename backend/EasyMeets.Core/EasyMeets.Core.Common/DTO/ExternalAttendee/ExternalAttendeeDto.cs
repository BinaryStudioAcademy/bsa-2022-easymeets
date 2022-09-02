namespace EasyMeets.Core.Common.DTO.ExternalAttendee;

public class ExternalAttendeeDto
{
    public long AvailabilitySlotId { get; set; }
    public long MeetingId { get; set; }
    public DateTimeOffset EventTime { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int TimeZone { get; set; }
}