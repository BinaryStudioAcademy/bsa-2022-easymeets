namespace EasyMeets.Core.DAL.Entities;

public class Location : Entity<long>
{
    public Location()
    {
        Meetings = new List<Meeting>();
        AvailabilitySlots = new List<AvailabilitySlot>();
    }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Meeting> Meetings { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
}
