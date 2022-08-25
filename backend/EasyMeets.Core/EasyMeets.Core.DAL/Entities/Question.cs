namespace EasyMeets.Core.DAL.Entities;

public class Question : Entity<long>
{
    public string Text { get; set; } = string.Empty;
    public bool IsMandatory { get; set; }
    
    public long AvailabilitySlotId { get; set;  }
    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
}
