namespace EasyMeets.Core.DAL.Entities;

public class Question : Entity<long>
{
    public int AvailabilitySlotId { get; set; }
    public string Text { get; set; } = string.Empty;

    public AvailabilitySlot AvailabilitySlot { get; set; }
}
