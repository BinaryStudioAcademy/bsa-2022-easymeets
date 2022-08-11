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
        private readonly IAvailabilityService _availabilityService;
        public UserController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }

        [HttpGet("current/{id}")]
        public async Task<ActionResult<UserDto>> GetCurrentUserAsync(int id)
        {
            var availabilitySlots = await _availabilityService.GetCurrentUserForAvailabilityPageAsync(id);
            return Ok(availabilitySlots);
        }
    }
}
