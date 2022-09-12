using EasyMeets.Watcher.BLL.Commands;
using EasyMeets.Watcher.BLL.Interfaces;
using EasyMeets.Watcher.BLL.Responses;
using MediatR;
using System.Net;

namespace EasyMeets.Watcher.BLL.Handlers
{
    public class NotifyCalendarHandler : IRequestHandler<NotifyCalendarCommand, NotifyCalendarResponse>
    {
        private readonly IWebHookNotifier _webHookNotifier;

        public NotifyCalendarHandler(IWebHookNotifier webHookNotifier)
        {
            _webHookNotifier=webHookNotifier;
        }

        public Task<NotifyCalendarResponse> Handle(NotifyCalendarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.VerifyCode != Environment.GetEnvironmentVariable("WebHookGoogleAuthorizationCode"))
                {
                    return Task.FromResult(new NotifyCalendarResponse { StatusCode = HttpStatusCode.Unauthorized });
                }
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong with Verify code.");
            }

            try
            {
                _webHookNotifier.NotifyCalendarChanges(request.Email);

                return Task.FromResult(new NotifyCalendarResponse { StatusCode = HttpStatusCode.OK });
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong with RabbitMQ Producer.");
            }
        }
    }
}
