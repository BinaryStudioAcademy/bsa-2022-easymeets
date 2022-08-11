using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class AdvancedSlotSettings : Entity<long>
{
    public ActivityType ActivityType { get; set; }
    public int Days { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public int MaxNumberOfBookings { get; set; }
    public int PaddingMeeting { get; set; }
    public int MinBookingMeetingDifference { get; set; }
    public Color Color { get; set; }

    public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
}
