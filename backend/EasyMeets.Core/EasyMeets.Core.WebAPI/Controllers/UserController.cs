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
            var email =  _userService.GetCurrentUserEmail();
            var user = await _userService.GetCurrentUserAsync(email);
            return Ok(user);
        } 
        
        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateUserPreferences([FromBody] NewUserDto user)
        {
            return Ok(await _userService.CreateUserPreferences(user));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePreferences([FromBody] UserDto user)
        {
            var email = _userService.GetCurrentUserEmail();
            await _userService.UpdateUserPreferences(user, email);
            return Ok();
        } 
    }
}
