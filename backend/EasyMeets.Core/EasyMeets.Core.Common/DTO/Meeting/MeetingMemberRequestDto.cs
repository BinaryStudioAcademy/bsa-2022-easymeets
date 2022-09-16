namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class MeetingMemberRequestDto
    {
        public long? TeamId { get; set; }
        public DateTimeOffset? Start { get; set; }
        public DateTimeOffset? End { get; set; }
    }
}
