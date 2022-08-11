using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class AvailabilitySlot : AuditEntity<long>
{
    public AvailabilitySlot()
    {
        ExternalAttendees = new List<ExternalAttendee>();
        Members = new List<UserSlot>();
        Questions = new List<Question>();
    }
    public long TeamId { get; set; }
    public long LocationId { get; set; }
    public long? AdvancedSlotSettingsId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string WelcomeMessage { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public int Frequency { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
    public string Language { get; set; } = string.Empty;
    public int BookingsPerDay { get; set; }
    public bool AllowToAddGuests { get; set; }
    public string? PasswordProtection { get; set; }
    public bool TimeZoneVisibility { get; set; }

    public User Author { get; set; } = null!;
    public Team Team { get; set; } = null!;
    public Location Location { get; set; } = null!;
    public AdvancedSlotSettings AdvancedSlotSettings { get; set; } = null!;
    public ICollection<ExternalAttendee> ExternalAttendees { get; set; }
    public ICollection<UserSlot> Members { get; set; }
    public ICollection<Question> Questions { get; set; }
}
