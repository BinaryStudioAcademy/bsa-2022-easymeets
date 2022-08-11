using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.UploadImage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UploadImageController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;

        public UploadImageController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }

        [HttpPut]
        public async Task<string> UploadImageAsync(ImageUploadDTO imageUploadDTO)
        {
            var imageUrl = await _uploadFileService.UploadFileBlobAsync(imageUploadDTO.filePath, imageUploadDTO.fileName, imageUploadDTO.userId);

            return imageUrl;
        }
    }
}
