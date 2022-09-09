using EasyMeets.RabbitMQ.Interface;
using EasyMeets.RabbitMQ.Service;
using EasyMeets.RabbitMQ.Settings;
using EasyMeets.Watcher.BLL.Interfaces;
using EasyMeets.Watcher.BLL.Queries;
using RabbitMQ.Client;

namespace EasyMeets.Watcher.WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRabbitMq(configuration);
        }

        private static void AddRabbitMq(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRabbitMqConnection(configuration);
            services.AddWebHookNotifier(configuration);
        }

        private static void AddWebHookNotifier(this IServiceCollection services, IConfiguration configuration)
        {
            var producerSettings = configuration
                .GetSection("RabbitMQConfiguration:Queues:WebHookProducer")
                .Get<ProducerSettings>();

            services.AddScoped<IWebHookNotifier>(provider =>
                new WebHookNotifier(
                    new ProducerService(
                        provider.GetRequiredService<IConnection>(),
                        producerSettings)));
        }

        private static void AddRabbitMqConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(provider =>
            {
                var rabbitConnection = new Uri(configuration.GetSection("RabbitMQConfiguration:Uri").Value);

                var connectionFactory = new ConnectionFactory
                { Uri = rabbitConnection, DispatchConsumersAsync = true };

                return connectionFactory.CreateConnection();
            });
        }
    }
}
