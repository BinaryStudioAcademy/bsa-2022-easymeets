using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class Meeting : AuditEntity<long>
{
    public Meeting()
    {
        SlotMembers = new List<SlotMember>();
    }
    public long TeamId { get; set; }
    public long AvailabilitySlotId { get; set; }
    public LocationType LocationType { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Duration { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public string MeetingLink { get; set; } = string.Empty;

    public AvailabilitySlot? AvailabilitySlot { get; set; }
    public Team Team { get; set; } = null!;
    public User Author { get; set; } = null!;
    public ICollection<SlotMember> SlotMembers { get; set; }
}
