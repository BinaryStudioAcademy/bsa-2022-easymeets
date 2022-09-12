using EasyMeets.Core.Common.Enums;
namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class MeetingSlotDTO
    {
        public long Id { get; set; }
        public DateTimeOffset MeetingTime { get; set; }
        public string? MeetingTitle { get; set; }
        public int MeetingDuration { get; set; }
        public string? MembersTitle { get; set; }
        public string? MeetingLink { get; set; }
        public LocationType? LocationType { get; set; }
        public string? MeetingRoom { get; set; }
        public int? MeetingCount { get; set; }
        public List<UserMeetingDTO>? MeetingMembers { get; set; }
    }
}
