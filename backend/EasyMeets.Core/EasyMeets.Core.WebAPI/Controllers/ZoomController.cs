using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ZoomController : ControllerBase
{
    private IZoomService _zoomService;
    public ZoomController(IZoomService zoomService)
    {
        _zoomService = zoomService;
    }

    [HttpPost("add")]
    public async Task<ActionResult<EmailDto>> CreateZoomCredentials([FromBody]NewCredentialsRequestDto newCredentialsRequestDto)
    {
        return Ok(await _zoomService.CreateZoomCredentials(newCredentialsRequestDto));
    }

    [HttpGet("client")]
    public ActionResult<string> GetZoomClientId()
    {
        var clientId = Environment.GetEnvironmentVariable("ZoomClientId");
        return Ok(clientId!);
    }

    [HttpGet("email")]
    public async Task<ActionResult<EmailDto>> GetZoomEmail()
    {
        return Ok(await _zoomService.GetZoomUserEmailAsync());
    }

    [HttpDelete("token")]
    public async Task<ActionResult> RevokeAccessToken()
    {
        await _zoomService.RevokeAccessTokenAsync();
        return NoContent();
    }
}
