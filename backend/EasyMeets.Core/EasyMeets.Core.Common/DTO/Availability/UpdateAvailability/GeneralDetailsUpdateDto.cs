using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;

public class GeneralDetailsUpdateDto
{
    public int SlotSize { get; set; }
    public int SlotFrequency { get; set; }
    public string MeetingLocation { get; set; }
    public int MeetingPadding { get; set;}
    public ActivityType SlotActivityOption { get; set; }
    public int SlotActivityValue { get; set; }
    public string MeetingName { get; set; }
    public int MaxBookings { get; set; }
    public int MinBookingMeetingDifference { get; set; }
    public bool HideFromCommon { get; set; }
    
    public Color Color { get; set; }
}