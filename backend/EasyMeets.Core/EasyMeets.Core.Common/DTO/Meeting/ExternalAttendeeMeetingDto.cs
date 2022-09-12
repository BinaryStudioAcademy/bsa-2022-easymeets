using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Meeting;

public class ExternalAttendeeMeetingDto
{
    public long TeamId { get; set; }
    public long CreatedBy { get; set; }
    public long AvailabilitySlotId { get; set; }
    public string Name { get; set; } = string.Empty;
    public LocationType LocationType { get; set; }
    public string? MeetingRoom { get; set; }
    public int Duration { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public string MeetingLink { get; set; }  = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}