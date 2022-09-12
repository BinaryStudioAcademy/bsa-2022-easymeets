using EasyMeets.Watcher.BLL.Responses;
using MediatR;

namespace EasyMeets.Watcher.BLL.Commands
{
    public class NotifyCalendarCommand : IRequest<NotifyCalendarResponse>
    {
        public string Email { get; set; } = string.Empty;
        public string VerifyCode { get; set; } = string.Empty;
    }
}
