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

        public EmailReminderJob(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            using var scope = _provider.CreateScope();
            var emailDelayService = scope.ServiceProvider.GetRequiredService<IEmailDelayService>();

            await emailDelayService.CheckForNotify(TemplateType.Reminders);
        }
    }
}
