using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums; 

namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class SaveMeetingDto
    {
        public long TeamId { get; set; } 
        public LocationType LocationType { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Duration { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public string MeetingLink { get; set; } = string.Empty;

        public List<NewMeetingMemberDto> MeetingMembers { get; set; } = new List<NewMeetingMemberDto>();
    }
}
