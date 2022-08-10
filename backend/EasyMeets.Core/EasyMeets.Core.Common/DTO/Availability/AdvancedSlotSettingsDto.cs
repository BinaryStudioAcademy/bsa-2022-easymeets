namespace EasyMeets.Core.Common.DTO.Availability;

public class AdvancedSlotSettingsDto
{
    public int ActivityType { get; set; }
    public int Days { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public int MaxNumberOfBookings { get; set; }
    public int PaddingBeforeMeeting { get; set; }
    public int BookingScheduleBlockingTimeMeetingInHours { get; set; }
    public int Color { get; set; }
}