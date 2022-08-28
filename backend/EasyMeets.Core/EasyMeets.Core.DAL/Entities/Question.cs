namespace EasyMeets.Core.DAL.Entities;

public class Question : Entity<long>
{
    public long AvailabilitySlotId { get; set; }
    public string QuestionText { get; set; } = string.Empty;

    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
}
