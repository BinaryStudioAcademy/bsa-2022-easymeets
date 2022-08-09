namespace EasyMeets.Core.DAL.Entities;

public class UserSlot : Entity<long>
{
    public long UserId { get; set; }
    public long AvailabilitySlotId { get; set; }

    public User User { get; set; }
    public AvailabilitySlot AvailabilitySlot { get; set; }
}