using EasyMeets.Core.Common.Enums;
using TimeZone = EasyMeets.Core.Common.Enums.TimeZone;

namespace EasyMeets.Core.Common.DTO.User
{
    public class UserDto
    {
        public long Id { get; set; }
        public string? Image { get; set; }
        public string? UserName { get; set; }      
        public Language Language { get; set; }
        public TimeFormat TimeFormat { get; set; }
        public DateFormat DateFormat { get; set; }
        public Country Country { get; set; }
        public string? Phone { get; set; }
        public TimeZone TimeZone { get; set; }
    }
}
