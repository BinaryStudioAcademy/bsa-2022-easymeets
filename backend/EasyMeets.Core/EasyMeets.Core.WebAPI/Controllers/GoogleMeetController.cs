using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials.GoogleMeet;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GoogleMeetController : ControllerBase
{
    private readonly IGoogleMeetService _googleMeetService;

    public GoogleMeetController(IGoogleMeetService googleMeetService)
    {
        _googleMeetService = googleMeetService;
    }

    [HttpGet("credentials/available")]
    public async Task<ActionResult<List<MeetCredentialsDto>>> GetAvailableCredentials()
    {
        return Ok(await _googleMeetService.GetAvailableEmails());
    }

    [HttpPost("credentials/create")]
    public async Task<ActionResult> CreateCredentials([FromBody] MeetCredentialsDto credentialsDto)
    {
        await _googleMeetService.CreateMeetCredentials(credentialsDto);
        return Ok();
    }
}