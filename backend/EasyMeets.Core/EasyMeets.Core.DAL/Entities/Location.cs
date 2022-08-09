namespace EasyMeets.Core.DAL.Entities;

public class Location : Entity<long>
{
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Meeting> Meetings { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
}
