using EasyMeets.Core.Common.DTO.Base;

namespace EasyMeets.Core.Common.DTO.User
{
    public class UserDto : BaseDto
    {
        public long Id { get; set; }
        public string Image { get; set; }
        public string UserName { get; set; }      
        public string Language { get; set; }
        public string TimeFormat { get; set; }
        public string DateFormat { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string TimeZone { get; set; }
    }
}
