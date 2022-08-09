using EasyMeets.Core.DAL.Entities.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class AdvancedSlotSettings : Entity<long>
{
    public int AvailabilitySlotId { get; set; }
    public ActivityType ActivityType { get; set; }
    public int Days { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public int MaxNumberOfBookings { get; set; }
    public int PaddingBeforeMeeting { get; set; }
    public int BookingScheduleBlockingTimeMeetingInHours { get; set; }
    public Color Color { get; set; }

    public AvailabilitySlot AvailabilitySlot { get; set; }
}
