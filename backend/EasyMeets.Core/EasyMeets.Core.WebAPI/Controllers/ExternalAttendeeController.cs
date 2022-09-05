using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ExternalAttendeeController : ControllerBase
{
    private readonly IExternalAttendeeService _attendeeService;

    public ExternalAttendeeController(IExternalAttendeeService attendeeService)
    {
        _attendeeService = attendeeService;
    }

    [HttpPost]
    public async Task<IActionResult> BookMeetingByExternalAttendee([FromBody] ExternalAttendeeAndBookedMeetingDto bookedMeetingDto)
    {
        await _attendeeService.SaveExternalAttendeeAsync(bookedMeetingDto);
        return Ok();
    }
}