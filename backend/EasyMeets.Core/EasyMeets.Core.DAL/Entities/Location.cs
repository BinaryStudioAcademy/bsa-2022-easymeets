using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Validation;

namespace EasyMeets.Core.DAL.Entities;

public class Location : Entity<long>, IValidatableObject
{
    public Location()
    {
        Meetings = new List<Meeting>();
        AvailabilitySlots = new List<AvailabilitySlot>();
    }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Meeting> Meetings { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!Name.IsValidMeetingLocation())
        {
            yield return new ValidationResult("Invalid meeting name");
        }
    }
}
