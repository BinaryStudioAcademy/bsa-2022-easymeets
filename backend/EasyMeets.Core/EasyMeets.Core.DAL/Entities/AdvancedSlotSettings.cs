using System.Drawing;

namespace EasyMeets.Core.DAL.Entities;

public class AdvancedSlotSettings : Entity<int>
{
    public int AvailabilitySlotId { get; set; }
    public int ActivityType { get; set; }
    public int Days { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int MaxNumberOfBookings { get; set; }
    public int PaddingBeforeMeeting { get; set; }
    public int BookingScheduleBlockingTimeMeetingInHours { get; set; }
    public Color Color { get; set; }

    public AvailabilitySlot AvailabilitySlot { get; set; }
}
