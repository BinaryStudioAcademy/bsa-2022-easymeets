namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class MeetingMemberRequestDto
    {
        public long? TeamId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
