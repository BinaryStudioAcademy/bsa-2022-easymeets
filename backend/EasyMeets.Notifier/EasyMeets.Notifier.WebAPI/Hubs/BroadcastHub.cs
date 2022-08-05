using Microsoft.AspNetCore.SignalR;
using EasyMeets.Notifier.Hubs.Interfaces;

namespace EasyMeets.Notifier.Hubs
{
    public class BroadcastHub : Hub<IBroadcastHubClient>
    {
    }
}