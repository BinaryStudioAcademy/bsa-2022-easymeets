namespace EasyMeets.Core.DAL.Entities;

public class ExternalAttendeeAvailability : AuditEntity<int>
{
    public int ExternalAttendeeId { get; set; }
    public DateTime StartEvent { get; set; }
    public DateTime EndEvent { get; set; }

    public ExternalAttendee ExternalAttendee { get; set; }
}
