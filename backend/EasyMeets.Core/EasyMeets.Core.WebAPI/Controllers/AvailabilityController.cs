using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
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
        
        [Authorize]
        [HttpGet("slot/{id}")]
        public async Task<ActionResult<AvailabilitySlotDto>> GetAvailabilitySlotById(long id)
        {
            var result = await _availabilityService.GetAvailabilitySlotById(id);
            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateAvailabilitySlot([FromBody] SaveAvailabilitySlotDto slotDto)
        {
            await _availabilityService.CreateAvailabilitySlot(slotDto);
            return Ok();
        } 

        [Authorize]
        [HttpGet("{id}/{teamId?}")]
        public async Task<ActionResult<UserPersonalAndTeamSlotsDto>> GetUserPersonalAndTeamSlotsAsync(long id, long? teamId)
        {
            var availabilitySlots = await _availabilityService.GetUserPersonalAndTeamSlotsAsync(id, teamId);
            return Ok(availabilitySlots);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult<AvailabilitySlotDto>> UpdateAvailabilitySlot(long id, [FromBody] SaveAvailabilitySlotDto updateAvailabilityDto)
        {
            return Ok(await _availabilityService.UpdateAvailabilitySlot(id, updateAvailabilityDto));
        }

        [Authorize]
        [HttpPost("enabling/{id}")]
        public async Task<ActionResult<bool>> UpdateAvailabilitySlotEnabling(long id)
        {
            return Ok(await _availabilityService.UpdateAvailabilitySlotEnablingAsync(id));
        }

        [Authorize]
        [HttpDelete("{slotId}")]
        public async Task<IActionResult> DeleteAvailabilitySlot(int slotId)
        {
            await _availabilityService.DeleteAvailabilitySlot(slotId);
            return NoContent();
        }

        [HttpGet("byLink/{link}")]
        public async Task<ActionResult<AvailabilitySlotDto?>> GetByLink(string link)
        {
            return Ok(await _availabilityService.GetByLink(link));
        }

        [HttpPut("{link}/externalSchedule")]
        public async Task<IActionResult> UpdateScheduleExternally(string link, [FromBody] ScheduleDto scheduleDto)
        {
            await _availabilityService.UpdateScheduleExternally(link, scheduleDto);
            return Ok();
        }
        
        [Authorize]
        [HttpGet("validateLink")]
        public async Task<ActionResult<bool>> ValidatePageLinkAsync(long? id, string slotLink)
        {
            return Ok(await _availabilityService.ValidateLinkAsync(id, slotLink));
        }
    }
}
