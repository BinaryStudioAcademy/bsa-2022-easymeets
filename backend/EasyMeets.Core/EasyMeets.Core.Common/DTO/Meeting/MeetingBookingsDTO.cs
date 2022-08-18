namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class MeetingBookingsDTO
    {
        public string? MeetingTime { get; set; }
        public string? MeetingTitle { get; set; }
        public string? MeetingDuration { get; set; }
        public string? MembersTitle { get; set; }
        public int? MeetingCount { get; set; }
        public List<UserMeetingDTO>? MeetingMembers { get; set; }
    }
}
