using EasyMeets.Watcher.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Watcher.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        private readonly IWebHookNotifier _webHookNotifier;

        public WebHookController(IWebHookNotifier webHookNotifier)
        {
            _webHookNotifier = webHookNotifier;
        }

        [HttpPost]
        public IActionResult SyncCalendars(string email, string verifyCode)
        {
            if (verifyCode != Environment.GetEnvironmentVariable("WebHookGoogleAuthorizationCode"))
            {
                return Unauthorized();
            }

            _webHookNotifier.NotifyCalendarChanges(email);

            return Ok();
        }
    }
}
