using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Meeting
{
    public class UserMeetingDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public TimeZoneDto TimeZone { get; set; } = null!;
        public DateTime Booked { get; set; }
    }
}
