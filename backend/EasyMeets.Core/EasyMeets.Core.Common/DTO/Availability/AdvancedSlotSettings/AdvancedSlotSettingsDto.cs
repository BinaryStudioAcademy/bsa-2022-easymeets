using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.AdvancedSlotSettings;

public class AdvancedSlotSettingsDto
{
    public ActivityType ActivityType { get; set; }
    public int Days { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public int MaxNumberOfBookings { get; set; }
    public int PaddingMeeting { get; set; }
    public int MinBookingMeetingDifference { get; set; }
    public Color Color { get; set; }
}