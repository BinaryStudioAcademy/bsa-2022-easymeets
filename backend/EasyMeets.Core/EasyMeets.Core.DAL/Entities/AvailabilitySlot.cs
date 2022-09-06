using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.Common.Validation;

namespace EasyMeets.Core.DAL.Entities;

public class AvailabilitySlot : AuditEntity<long>, IValidatableObject
{
    public AvailabilitySlot()
    {
        ExternalAttendees = new List<ExternalAttendee>();
        Questions = new List<Question>();
        EmailTemplates = new List<EmailTemplate>();
        SlotMembers = new List<SlotMember>();
    }
    public long TeamId { get; set; }
    public LocationType LocationType { get; set; }
    public string Name { get; set; } = string.Empty;
    public string WelcomeMessage { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public Color Color { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
    public string Language { get; set; } = string.Empty;
    public int BookingsPerDay { get; set; }
    public bool PasswordProtectionIsUsed { get; set; }
    public string? PasswordProtection { get; set; }
    public bool TimeZoneVisibility { get; set; }

    public User Author { get; set; } = null!;
    public Team Team { get; set; } = null!;
    public AdvancedSlotSettings? AdvancedSlotSettings { get; set; }
    public ICollection<Meeting>? Meetings { get; set; }
    public ICollection<ExternalAttendee> ExternalAttendees { get; set; }
    public ICollection<Question> Questions { get; set; }
    public ICollection<EmailTemplate> EmailTemplates { get; set; }
    public ICollection<SlotMember> SlotMembers { get; set; }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!Name.IsValidUsername() || Name.Length is < 1 or > 50)
        {
            yield return new ValidationResult("Invalid meeting name");
        }

        if (Size < 1)
        {
            yield return new ValidationResult("Slot size must be a natural number");
        }

        if (PasswordProtection is not null && (!PasswordProtection.IsValidPassword() || PasswordProtection.Length is < 3 or > 8))
        {
            yield return new ValidationResult("Invalid password format");
        }
    }
}
