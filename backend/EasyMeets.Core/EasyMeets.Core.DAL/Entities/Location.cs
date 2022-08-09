namespace EasyMeets.Core.DAL.Entities;

public class Location : AuditEntity<int>
{
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Meeting> Meetings { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
}
