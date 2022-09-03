using EasyMeets.Core.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        private readonly IWebHookService _webHookService;
        public WebHookController(IWebHookService webHookService)
        {
            _webHookService = webHookService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(string email)
        {
            await _webHookService.GetNofiticationCalendarEvents(email);

            return Ok();
        }
    }
}
