using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.UploadImage;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{ 
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
        public async Task<IActionResult> UploadImageAsync()
        {
            var formCollection = await Request.ReadFormAsync();
            var file = formCollection.Files.First();
            ImageUploadDTO imageUploadDTO = new ImageUploadDTO();
            var imageUrl = await _uploadFileService.UploadFileBlobAsync(imageUploadDTO.FilePath, imageUploadDTO.FileName, imageUploadDTO.UserId);

            if (imageUrl is null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
