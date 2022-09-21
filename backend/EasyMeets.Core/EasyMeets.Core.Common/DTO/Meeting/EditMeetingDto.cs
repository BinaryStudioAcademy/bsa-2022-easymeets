using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Meeting;

public class EditMeetingDto
{
    public long Id { get; set; }
    public DateTimeOffset MeetingTime { get; set; }
    public string? MeetingTitle { get; set; }
    public int MeetingDuration { get; set; }
    public string? MembersTitle { get; set; }
    public string? MeetingLink { get; set; }
    public LocationType? LocationType { get; set; }
    public string? MeetingRoom { get; set; }
    public List<NewMeetingMemberDto>? MeetingMembers { get; set; }
}