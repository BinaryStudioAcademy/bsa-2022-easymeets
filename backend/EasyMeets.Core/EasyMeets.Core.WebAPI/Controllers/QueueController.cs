using EasyMeets.Core.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    {
        private readonly IInformQueueService _queueService;

        public QueueController(IInformQueueService queueService)
        {
            _queueService = queueService;
        }

        [HttpPost("InformEveryone")]
        public ActionResult InformEveryone(string message)
        {
            _queueService.InformEveryone(message);

            return Ok();
        }
    }
}
