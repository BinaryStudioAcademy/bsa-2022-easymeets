using EasyMeets.Core.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Authorize]
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
            var fileName = Path.GetFileName(file.FileName);

            var imageUrl = await _uploadFileService.UploadFileBlobAsync(file, fileName, 2);

            if (imageUrl is null)
            {
                return NotFound();
            }

            return Ok(new { imagePath = imageUrl });
        }
    }
}
