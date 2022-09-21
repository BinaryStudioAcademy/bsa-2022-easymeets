using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.Enums;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace EasyMeets.Core.BLL.Services.Quartz
{
    [DisallowConcurrentExecution]
    public class EmailReminderJob : IJob
    {
        private readonly IServiceProvider _provider;
        private static DateTime _lastSentTime;

        public EmailReminderJob(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            if (_lastSentTime == DateTime.MinValue)
            {
                _lastSentTime = DateTime.Now.AddMinutes(-1);
            }

            using var scope = _provider.CreateScope();
            var emailDelayService = scope.ServiceProvider.GetRequiredService<IEmailDelayService>();

            await emailDelayService.CheckForNotify(TemplateType.Reminders, _lastSentTime);

            _lastSentTime = DateTime.Now;
        }
    }
}
