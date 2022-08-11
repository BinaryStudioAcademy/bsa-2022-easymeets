using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.Common.DTO.Availability; 
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("current/{id}")]
        public async Task<ActionResult<UserDto>> GetCurrentUserAsync(int id)
        {
            var availabilitySlots = await _userService.GetCurrentUserForAvailabilityPageAsync(id);
            return Ok(availabilitySlots);
        }
    }
}
