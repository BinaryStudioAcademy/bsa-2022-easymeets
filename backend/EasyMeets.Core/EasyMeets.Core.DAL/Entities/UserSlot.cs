namespace EasyMeets.Core.DAL.Entities;

public class UserSlot : Entity<long>
{
    public int UserId { get; set; }
    public int AvailabilitySlotId { get; set; }

    public User User { get; set; }
    public AvailabilitySlot AvailabilitySlot { get; set; }
}