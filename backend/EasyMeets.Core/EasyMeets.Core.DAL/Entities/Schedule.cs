using TimeZone = EasyMeets.Core.Common.Enums.TimeZone;

namespace EasyMeets.Core.DAL.Entities;

public class Schedule
{
    public long AvailabilitySlotId { get; set; }
    public TimeZone TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }

    public ICollection<TeamMemberMeeting> Members { get; set; } = new List<TeamMemberMeeting>();
    public ICollection<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();
}