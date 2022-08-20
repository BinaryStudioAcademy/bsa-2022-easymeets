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
        private readonly IUserService _userService;

        public UploadImageController(IUploadFileService uploadFileService, IUserService userService)
        {
            _uploadFileService = uploadFileService;
            _userService = userService;
        }

        [HttpPut] 
        public async Task<IActionResult> UploadImageAsync([FromForm] IFormFile file)
        {  
            try
            {
                var currentUserEmail = _userService.GetCurrentUserEmail();
                var user = await _userService.GetCurrentUserAsync(currentUserEmail);
                var imageUrl = await _uploadFileService.UploadFileBlobAsync(file, user.Id); if (imageUrl is null)
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
