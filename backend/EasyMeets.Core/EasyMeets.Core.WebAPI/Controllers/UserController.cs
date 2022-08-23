using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("current")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userService.GetCurrentUserAsync();
            return Ok(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> CreateUserPreferences([FromBody] NewUserDto user)
        {
            return Ok(await _userService.CreateUserPreferences(user));
        }

        [HttpGet("check-email")]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> CheckUserExistingByEmail(string email)
        {
            return Ok(await _userService.CheckExistingUserByEmail(email));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePreferences([FromBody] UserDto user)
        {
            var email = _userService.GetCurrentUserEmail();
            await _userService.UpdateUserPreferences(user, email);
            return Ok();
        }


        [HttpPut("uploadimage")]
        public async Task<IActionResult> UploadImageAsync([FromForm] IFormFile file)
        {
            try
            {
                var user = await _userService.GetCurrentUserAsync();
                var imageUrl = await _userService.UploadImageAsync(file); if (imageUrl is null)
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
