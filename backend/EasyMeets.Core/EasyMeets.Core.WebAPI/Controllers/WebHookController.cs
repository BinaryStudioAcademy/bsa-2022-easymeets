using EasyMeets.Core.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        private readonly ICalendarsService _calendarsService;
        private readonly IConfiguration _configuration;

        public WebHookController(ICalendarsService calendarsService, IConfiguration configuration)
        {
            _calendarsService = calendarsService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(string email, string verifyCode)
        {
            if (verifyCode != _configuration["GoogleCalendar:WebHookGoogleAuthorizationCode"])
            {
                return Unauthorized();
            }

            var result = await _calendarsService.SyncChangesFromGoogleCalendar(email);

            if(result)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
