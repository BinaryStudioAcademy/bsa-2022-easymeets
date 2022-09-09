using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.RabbitMQ.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client.Events;
using System.Text;

namespace EasyMeets.Core.BLL.Services.Queue
{
    public class WebHookListenerService : BackgroundService
    {
        private readonly IConsumerService _consumer;
        private readonly IServiceProvider _provider;

        public WebHookListenerService(IConsumerService consumer, IServiceProvider provider)
        {
            _consumer = consumer;
            _provider = provider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _consumer.Listen(SyncCalendars);

            await Task.CompletedTask;
        }

        private async void SyncCalendars(object? sender, BasicDeliverEventArgs args)
        {
            var messageString = Encoding.UTF8.GetString(args.Body.ToArray());

            using var scope = _provider.CreateScope();
            var calendarService = scope.ServiceProvider.GetRequiredService<ICalendarsService>();

            try
            {
                await calendarService.SyncChangesFromGoogleCalendar(messageString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _consumer.SetAcknowledge(args.DeliveryTag, true);
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            _consumer.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
