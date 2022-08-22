using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarsService _calendarsService;

        public CalendarController(ICalendarsService calendarsService)
        {
            _calendarsService = calendarsService;
        }
        
        [HttpPost("create-connection")]
        public async Task<ActionResult<bool>> CreateGoogleCalendarConnection([FromBody] UserCredentialsDto userCredentialsDto)
        {
            return Ok(await _calendarsService.CreateGoogleCalendarConnection(userCredentialsDto));
        }
        
        [HttpPost("create-calendar")]
        public async Task<IActionResult> CreateGoogleCalendar()
        {
            return Ok(await _calendarsService.CreateCalendar());
        }
    }
}