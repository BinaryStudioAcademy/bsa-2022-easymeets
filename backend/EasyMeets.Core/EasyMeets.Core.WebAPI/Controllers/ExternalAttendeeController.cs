using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.User;
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

    [HttpGet("personal-slots/{personalLink}")]
    public async Task<ActionResult<ExternalAttendeeBookingInfoDto>> GetOrganizerAndPersonalSlots(string personalLink)
    {
        return Ok(await _attendeeService.GetOrganizerAndPersonalSlotsAsync(personalLink));
    }
    
    [HttpGet("organizer/{slotLink}")]
    public async Task<ActionResult<ExternalUserDto>> GetOrganizerBySlotLink(string slotLink)
    {
        return Ok(await _attendeeService.GetOrganizerBySlotLinkAsync(slotLink));
    }

    [HttpPost]
    public async Task<IActionResult> BookMeetingByExternalAttendee([FromBody] ExternalAttendeeAndBookedMeetingDto bookedMeetingDto)
    {
        await _attendeeService.SaveExternalAttendeeAsync(bookedMeetingDto);
        return Ok();
    }
}