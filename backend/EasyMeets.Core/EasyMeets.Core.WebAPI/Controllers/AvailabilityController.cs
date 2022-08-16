using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvailabilityController : ControllerBase
    {
        private readonly IAvailabilityService _availabilityService;
        public AvailabilityController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }
        
        [HttpGet("slot/{id}")]
        public async Task<ActionResult<AvailabilitySlotDto>> GetAvailabilitySlotById(long id)
        {
            return Ok(await _availabilityService.GetAvailabilitySlotById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAvailabilitySlot([FromBody] NewAvailabilitySlotDto slotDto)
        {
            await _availabilityService.CreateAvailabilitySlot(slotDto);
            return Ok();
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<UserPersonalAndTeamSlotsDto>> GetUserPersonalAndTeamSlotsAsync(long id)
        {
            var availabilitySlots = await _availabilityService.GetUserPersonalAndTeamSlotsAsync(id);
            return Ok(availabilitySlots);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AvailabilitySlotDto>> UpdateAvailabilitySlot(long id, [FromBody] UpdateAvailabilityDto updateAvailabilityDto)
        {
            return Ok(await _availabilityService.UpdateAvailabilitySlot(id, updateAvailabilityDto));
        }
    }
}
