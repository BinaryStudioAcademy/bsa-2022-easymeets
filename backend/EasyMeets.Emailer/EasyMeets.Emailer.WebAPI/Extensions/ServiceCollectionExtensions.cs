using EasyMeets.Emailer.WebAPI.HostedServices;
using EasyMeets.Emailer.WebAPI.Services;
using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using EasyMeets.RabbitMQ.Interface;
using EasyMeets.RabbitMQ.Service;
using EasyMeets.RabbitMQ.Settings;
using RabbitMQ.Client;

namespace EasyMeets.Emailer.WebAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddEmailQueueListener(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IEmailService, EmailService>();
        
        var settings = configuration
            .GetSection("RabbitMQConfiguration:Queues:EmailConsumer")
            .Get<ConsumerSettings>();

        services.AddSingleton<IConsumerService>(provider => new ConsumerService(
            provider.GetRequiredService<IConnection>(),
            settings));
        
        services.AddHostedService<EmailQueueListener>();
    }
    
    public static void AddRabbitMqConnection(this IServiceCollection services, IConfiguration configuration)
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