using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("current/{id}")]
        public async Task<ActionResult<UserDto>> GetCurrentUserByIdAsync(int id)
        {
            var availabilitySlots = await _userService.GetCurrentUserAsync(id);
            return Ok(availabilitySlots);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetPreferencesById(long id)
        {
            var user = await _userService.GetUserPreferences(id);
            if (user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePreferences([FromBody] UserDto user)
        {
            await _userService.UpdateUserPreferences(user);
            return Ok();
        }
    }
}
