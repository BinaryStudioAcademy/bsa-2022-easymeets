using EasyMeets.Core.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace EasyMeets.Core.BLL.Services.Quartz
{
    [DisallowConcurrentExecution]
    public class EmailDelayJob : IJob
    {
        private readonly IServiceProvider _provider;

        public EmailDelayJob(IServiceProvider provider)
        {
            _provider = provider;
        }

        public Task Execute(IJobExecutionContext context)
        {
            using var scope = _provider.CreateScope();
            var emailDelayService = scope.ServiceProvider.GetRequiredService<IEmailDelayService>();

            return emailDelayService.CheckForNotify();
        }
    }
}
