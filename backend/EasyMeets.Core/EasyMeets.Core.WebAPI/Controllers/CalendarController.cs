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

        [HttpGet("user-calendars")] 
        public async Task<ActionResult<List<UserCalendarDto>>> GetCurrentUserGoogleCalendars()
        {
            return Ok(await _calendarsService.GetCurrentUserCalendars());
        }
        
        [HttpDelete("{id}")] 
        public async Task<ActionResult<bool>> DeleteGoogleCalendar(long id)
        {
            return Ok(await _calendarsService.DeleteCalendar(id));
        }

        [HttpPut("update-calendar")]
        public async Task<ActionResult<bool>> UpdateCalendar([FromBody] List<UserCalendarDto> calendarDtoList)
        {
            return Ok(await _calendarsService.UpdateGoogleCalendar(calendarDtoList));
        }
    }
}