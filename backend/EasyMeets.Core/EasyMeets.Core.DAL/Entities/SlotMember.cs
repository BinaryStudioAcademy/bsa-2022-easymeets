namespace EasyMeets.Core.DAL.Entities;

public class SlotMember : Entity<long>
{
    public long MemberId { get; set; }
    public long SlotId { get; set; }
    public long ScheduleId { get; set; }
    public int Priority { get; set; }

    public Schedule Schedule { get; set; } = null!;
    public User User { get; } = null!;
    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
}
