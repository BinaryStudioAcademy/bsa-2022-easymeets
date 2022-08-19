using EasyMeets.Core.BLL.Interfaces;
using Google.Apis.Auth.AspNetCore3;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers;

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
    
    [HttpGet("get-calendar")]
    public async Task<ActionResult<string>> GetAvailabilitySlotById([FromServices] IGoogleAuthProvider auth)
    {
        return Ok(await _calendarsService.GetCalendar(auth));
    }
}