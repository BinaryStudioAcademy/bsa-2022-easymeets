namespace EasyMeets.Core.DAL.Entities;

public class Schedule : Entity<long>
{
    public long AvailabilitySlotId { get; set; }
    /// <summary>
    /// Represents difference with GMT in minutes
    /// </summary>
    public int TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }

    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
    public ICollection<SlotMember> Members { get; set; } = new List<SlotMember>();
    public ICollection<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();
}