using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GoogleOAuthController : ControllerBase
{
    private readonly IGoogleOAuthService _authService;
    private readonly ICalendarsService _calendarsService;
    private readonly IUserService _userService;
    private readonly IConfiguration _configuration;
    private static UserDto? CurrentUser { get; set; }
    
    public GoogleOAuthController(IGoogleOAuthService authService, ICalendarsService calendarsService, IUserService userService, IConfiguration configuration)
    {
        _calendarsService = calendarsService;
        _authService = authService;
        _userService = userService;
        _configuration = configuration;
    }
    
    [Authorize]
    [HttpGet("redirect")]
    public async Task<ActionResult<string>> RedirectOnAuthServer()
    {
        CurrentUser = await _userService.GetCurrentUserAsync();
        return Ok(_authService.GetAuthorizationUrl());
    }
    
    [HttpGet("code")]
    public async Task<IActionResult> Code(string code)
    {
        var codeVerifier = Environment.GetEnvironmentVariable("codeVerifier");
        var tokenResult = await _authService.ExchangeCodeOnToken(code, codeVerifier!, _configuration["GoogleCalendar:RedirectUrl"]);
        await _calendarsService.CreateGoogleCalendarConnection(tokenResult, CurrentUser!);
        return Redirect(_configuration["GoogleCalendar:CalendarsPageUrl"]);
    }
    
}