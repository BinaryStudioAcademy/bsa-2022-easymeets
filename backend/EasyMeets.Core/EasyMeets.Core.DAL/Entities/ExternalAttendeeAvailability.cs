namespace EasyMeets.Core.DAL.Entities;

public class ExternalAttendeeAvailability : Entity<long>
{
    public int ExternalAttendeeId { get; set; }
    public DateTimeOffset StartEvent { get; set; }
    public DateTimeOffset EndEvent { get; set; }

    public ExternalAttendee ExternalAttendee { get; set; }
}
