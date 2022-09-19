using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class UserMeetingDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public TimeZoneDto TimeZone { get; set; } = null!;
        public DateTime Booked { get; set; }
        public ICollection<QuestionDto> Questions { get; set; } = new List<QuestionDto>();
        public string? MeetingName { get; set; }
        public int MeetingDuration { get; set; }
        public DateTimeOffset MeetingDate { get; set; }
    }
}
