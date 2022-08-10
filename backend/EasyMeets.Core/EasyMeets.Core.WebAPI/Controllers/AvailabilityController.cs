using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
   // [Authorize]
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
        public async Task<ActionResult<ICollection<AvailabilitySlot>>> GetAllAsync()
        {
            var availabilitySlots = await _availabilityService.GetAllAvailabilitySlotsAsync();
            return Ok(availabilitySlots);
        }
    }
}
