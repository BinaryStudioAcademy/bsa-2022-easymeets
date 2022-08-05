using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using EasyMeets.Notifier.Hubs;
using EasyMeets.Notifier.Hubs.Interfaces;

namespace EasyMeets.Notifier.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BroadcastController : ControllerBase
    {
        private readonly IHubContext<BroadcastHub, IBroadcastHubClient> _hubContext;

        public BroadcastController(IHubContext<BroadcastHub, IBroadcastHubClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public Task BroadcastMessage(string message)
            => _hubContext.Clients.All.BroadcastMessage(message);
    }
}