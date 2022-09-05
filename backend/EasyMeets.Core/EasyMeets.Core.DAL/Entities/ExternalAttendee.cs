using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Validation;

namespace EasyMeets.Core.DAL.Entities;

public class ExternalAttendee : Entity<long>, IValidatableObject
{
    public long AvailabilitySlotId { get; set; }
    public long MeetingId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string TimeZoneValue { get; set; } = string.Empty;
    public string TimeZoneName { get; set; } = string.Empty;

    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
    public Meeting Meeting { get; set; } = null!;
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!Name.IsValidUsername() || Name.Length is < 2 or > 50)
        {
            yield return new ValidationResult("Invalid name");
        }

        if (!Email.IsValidEmail() || Email.Length is < 5 or > 51)
        {
            yield return new ValidationResult("Invalid email");
        }
    }
}
