using System.Security.Claims;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        
        [HttpGet("current/{id}")]
        public async Task<ActionResult<UserDto>> GetCurrentUserByIdAsync(int id)
        {
            var availabilitySlots = await _userService.GetCurrentUserAsync(id, GetCurrentUserEmail());
            return Ok(availabilitySlots);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetPreferencesById(long id)
        {
            var user = await _userService.GetUserPreferences(id, GetCurrentUserEmail());
            if (user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePreferences([FromBody] UserDto user)
        {
            await _userService.UpdateUserPreferences(user, GetCurrentUserEmail());
            return Ok();
        }

        private string GetCurrentUserEmail()
        {
            var claimsList=  _httpContextAccessor.HttpContext!.User.Claims.ToList();
            var email = claimsList.Find(el => el.Type == ClaimTypes.Email);
            return email!.Value;
        }
    }
}
