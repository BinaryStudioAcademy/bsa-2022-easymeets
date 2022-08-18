using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.User
{
    public class UserDto : EntityDto<long>
    {
        public string Email { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public Language Language { get; set; }
        public TimeFormat TimeFormat { get; set; }
        public DateFormat DateFormat { get; set; }
        public Country Country { get; set; }
        public string Phone { get; set; } = string.Empty;
        public int TimeZone { get; set; }
    }
}
