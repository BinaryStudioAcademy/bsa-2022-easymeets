namespace EasyMeets.Core.DAL.Entities;

public class Question : Entity<long>
{
    public int Order { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public bool IsMandatory { get; set; }
    
    public long AvailabilitySlotId { get; set;  }
    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
}
