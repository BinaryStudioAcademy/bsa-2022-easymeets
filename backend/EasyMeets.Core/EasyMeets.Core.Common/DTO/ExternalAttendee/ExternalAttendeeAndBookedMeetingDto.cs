using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.Common.DTO.ExternalAttendee;

public class ExternalAttendeeAndBookedMeetingDto
{
    public ExternalAttendeeDto Attendee { get; set; } = new();
    public ExternalAttendeeMeetingDto Meeting { get; set; } = new();
}