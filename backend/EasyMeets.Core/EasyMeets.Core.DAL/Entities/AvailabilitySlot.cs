using EasyMeets.Core.DAL.Entities.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class AvailabilitySlot : AuditEntity<long>
{
    public int TeamId { get; set; }
    public int LocationId { get; set; }
    public int? AdvancedSlotSettingsId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public int Frequency { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }

    public User Author { get; set; }
    public Team Team { get; set; }
    public Location Location { get; set; }
    public AdvancedSlotSettings AdvancedSlotSettings { get; set; }
    public ICollection<ExternalAttendee> ExternalAttendees { get; set; }
    public ICollection<UserSlot> Members { get; set; }
    public ICollection<Question> Questions { get; set; }
}
