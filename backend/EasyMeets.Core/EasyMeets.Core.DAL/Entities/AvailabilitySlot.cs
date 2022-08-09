namespace EasyMeets.Core.DAL.Entities;

public class AvailabilitySlot : AuditEntity<int>
{
    public int AuthorId { get; set; }
    public int TeamId { get; set; }
    public int LocationId { get; set; }
    public int? AdvancedSlotSettingsId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public int State { get; set; }
    public int Type { get; set; }
    public int Size { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }

    public User Author { get; set; }
    public Team Team { get; set; }
    public Location Location { get; set; }
    public AdvancedSlotSettings AdvancedSlotSettings { get; set; }
    public ICollection<ExternalAttendee> ExternalAttendees { get; set; }
    public ICollection<UserSlot> UserSlots { get; set; }
    public ICollection<Question> Questions { get; set; }
}
