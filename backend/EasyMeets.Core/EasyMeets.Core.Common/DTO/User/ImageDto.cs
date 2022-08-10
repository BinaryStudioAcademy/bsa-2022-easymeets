using Microsoft.AspNetCore.Http;

namespace EasyMeets.Core.Common.DTO.User
{
    public class ImageDto
    {
        public long UserId { get; set; }
        public IFormFile Image { get; set; }
    }
}
