using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.Common.Validation;

namespace EasyMeets.Core.DAL.Entities;

public class User : Entity<long>, IValidatableObject
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? ImagePath { get; set; }
    public Language Language { get; set; }
    public TimeFormat TimeFormat { get; set; }
    public DateFormat DateFormat { get; set; }
    public Country? Country { get; set; }
    public Common.Enums.TimeZone? TimeZone { get; set; }
    public bool IsBanned { get; set; }

    public ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
    public ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();
    public ICollection<Meeting> CreatedMeetings { get; set; } = new List<Meeting>();
    public ICollection<SlotMember> TeamMeetings { get; set; } = new List<SlotMember>();
    public ICollection<UserSlot> Slots { get; set; } = new List<UserSlot>();
    public ICollection<AvailabilitySlot> CreatedSlots { get; set; } = new List<AvailabilitySlot>();
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!Name.IsValidUsername() || Name.Length is < 2 or > 50)
        {
            yield return new ValidationResult("Invalid user name");
        }
        
        if(!Email.IsValidEmail() || Email.Length is < 5 or > 51)
        {
            yield return new ValidationResult("Invalid email");
        }

        if (!PhoneNumber!.IsValidPhoneNumber())
        {
            yield return new ValidationResult("Invalid phone number");
        }
    }
}
