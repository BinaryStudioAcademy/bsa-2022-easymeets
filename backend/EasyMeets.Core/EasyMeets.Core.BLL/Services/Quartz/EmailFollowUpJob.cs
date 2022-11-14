using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.Enums;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace EasyMeets.Core.BLL.Services.Quartz
{
    [DisallowConcurrentExecution]
    public class EmailFollowUpJob : IJob
    {
        private readonly IServiceProvider _provider;
        private static DateTime _lastSentTime;

        public EmailFollowUpJob(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            if (_lastSentTime == DateTime.MinValue)
            {
                _lastSentTime = DateTime.UtcNow.AddMinutes(-1);
            }

            using var scope = _provider.CreateScope();
            var emailDelayService = scope.ServiceProvider.GetRequiredService<IEmailDelayService>();

            await emailDelayService.CheckForNotify(TemplateType.FollowUp, _lastSentTime);

            _lastSentTime = DateTime.UtcNow;
        }
    }
}
