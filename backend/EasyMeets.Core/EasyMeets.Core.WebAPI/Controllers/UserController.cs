using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.UploadImage;
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

        [HttpGet("byLink/{link}")]
        public async Task<ActionResult<UserDto>> GetUserByPersonalUrl(string link)
        {
            return Ok(await _userService.GetUserByPersonalLink(link));
        }

        [HttpGet("search/{searchData}")]
        public async Task<List<UserDto>> GetUsersByEmailOrNameAsync(string searchData)
        {
            var users = await _userService.GetUsersByEmailOrNameAsync(searchData);
            return users;
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
        public async Task<IActionResult> UpdatePreferences([FromBody] UpdateUserDto user)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var updatedUser = await _userService.UpdateUserPreferences(user, currentUser.Email);

            return Ok(updatedUser);
        }

        [HttpPut("uploadimage")]
        public async Task<ActionResult<ImagePathDto>> UploadImageAsync([FromForm] IFormFile file)
        {
            var imagePath = await _userService.UploadImageAsync(file);
            return Ok(imagePath);
        }
    }
}
