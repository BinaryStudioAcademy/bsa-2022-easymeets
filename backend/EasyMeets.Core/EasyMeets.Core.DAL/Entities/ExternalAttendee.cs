namespace EasyMeets.Core.DAL.Entities;

public class ExternalAttendee : Entity<long>
{
    public ExternalAttendee()
    {
        ExternalAttendeeAvailabilities = new List<ExternalAttendeeAvailability>();
    }
    public long AvailabilitySlotId { get; set; }
    public DateTimeOffset EventTime { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
    public ICollection<ExternalAttendeeAvailability> ExternalAttendeeAvailabilities { get; set; }
}
