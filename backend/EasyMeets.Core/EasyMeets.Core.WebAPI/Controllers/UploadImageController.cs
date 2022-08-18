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

        [HttpPut ("{id}")] 
        public async Task<IActionResult> UploadImageAsync(int id, [FromForm] IFormFile file)
        {  
            try
            { 
                var imageUrl = await _uploadFileService.UploadFileBlobAsync(file,  id); if (imageUrl is null)
                {
                    return NotFound();
                } 
                return Ok(new { imagePath = imageUrl });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            } 
        }
    }
}
