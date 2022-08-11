using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.User
{
    public class UserDto : EntityDto<long>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string? ImagePath { get; set; } 
    }
}
