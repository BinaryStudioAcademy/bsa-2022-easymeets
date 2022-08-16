using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class AdvancedSlotSettings : Entity<long>, IValidatableObject
{
    public long? AvailabilitySlotId { get; set; }
    public ActivityType ActivityType { get; set; }
    public int Days { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public int MaxNumberOfBookings { get; set; }
    public int PaddingMeeting { get; set; }
    public int MinBookingMeetingDifference { get; set; }
    public Color Color { get; set; }

    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Days is < 1 or > 999)
        {
            yield return new ValidationResult("Slot activity time must be 1 to 3 digit natural number");
        }
        
        if (MaxNumberOfBookings is < 1 or > 999)
        {
            yield return new ValidationResult("Max number of bookings must be 1 to 3 digit natural number");
        }

        if (PaddingMeeting < 1)
        {
            yield return new ValidationResult("Meeting padding must be a natural number");
        }

        if (MinBookingMeetingDifference < 1)
        {
            yield return new ValidationResult("Max booking-meeting differance must be a natural number");
        }
    }
}
