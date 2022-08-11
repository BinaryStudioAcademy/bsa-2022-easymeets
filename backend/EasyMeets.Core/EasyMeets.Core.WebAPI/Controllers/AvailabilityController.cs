﻿using EasyMeets.Core.BLL.Interfaces; 
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability; 
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    //TODO: return Authorize
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AvailabilityController : ControllerBase
    {
        private readonly IAvailabilityService _availabilityService;
        public AvailabilityController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAvailabilitySlot([FromBody] NewAvailabilitySlotDto slotDto)
        {
            await _availabilityService.CreateAvailabilitySlot(slotDto);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<AvailabilitySlotDto>>> GetAllAvailabilitySlotsForTeamAsync()
        {
            var availabilitySlots = await _availabilityService.GetAllAvailabilitySlotsForTeamAsync();
            return Ok(availabilitySlots);
        }
    }
}
