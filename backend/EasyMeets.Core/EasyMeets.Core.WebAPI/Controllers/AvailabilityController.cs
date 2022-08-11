using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability; 
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

        [HttpGet]
        public async Task<ActionResult<ICollection<AvailabilitySlotDto>>> GetAllAvailabilitySlotsForTeamAsync()
        {
            var availabilitySlots = await _availabilityService.GetAllAvailabilitySlotsForTeamAsync();
            return Ok(availabilitySlots);
        }
    }
}
