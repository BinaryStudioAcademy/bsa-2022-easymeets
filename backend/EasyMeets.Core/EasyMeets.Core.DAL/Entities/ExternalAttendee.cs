namespace EasyMeets.Core.DAL.Entities;

public class ExternalAttendee : AuditEntity<int>
{
    public int AvailabilitySlotId { get; set; }
    public DateTime EventTime { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public AvailabilitySlot TypeAvailabilitySlot { get; set; }
    public ICollection<ExternalAttendeeAvailability> ExternalAttendeeAvailabilities { get; set; }
}
