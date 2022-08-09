namespace EasyMeets.Core.DAL.Entities;

public class Question : Entity<long>
{
    public Question()
    {
        AvailabilitySlot = new AvailabilitySlot();
    }
    public long AvailabilitySlotId { get; set; }
    public string Text { get; set; } = string.Empty;

    public AvailabilitySlot AvailabilitySlot { get; set; }
}
