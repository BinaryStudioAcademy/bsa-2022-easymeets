using EasyMeets.Watcher.BLL.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EasyMeets.Watcher.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WebHookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SyncCalendars([FromBody] NotifyCalendarCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);

                if (result.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Unauthorized();
                }

                return Ok();
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }
    }
}
