using EasyMeets.Emailer.WebAPI.HostedServices;
using EasyMeets.Emailer.WebAPI.Services;
using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using EasyMeets.RabbitMQ.Interface;
using EasyMeets.RabbitMQ.Service;
using EasyMeets.RabbitMQ.Settings;
using RabbitMQ.Client;
using sib_api_v3_sdk.Client;

namespace EasyMeets.Emailer.WebAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEmailService(configuration);
        services.AddRabbitMq(configuration);
    }
    
    private static void AddRabbitMq(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRabbitMqConnection(configuration);
        services.AddEmailQueueListener(configuration);
    }
    
    private static void AddEmailQueueListener(this IServiceCollection services, IConfiguration configuration)
    {
        var settings = configuration
            .GetSection("RabbitMQConfiguration:Queues:EmailConsumer")
            .Get<ConsumerSettings>();

        services.AddSingleton<IConsumerService>(provider => new ConsumerService(
            provider.GetRequiredService<IConnection>(),
            settings));
        
        services.AddHostedService<EmailQueueListener>();
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

    private static void AddEmailService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IEmailService, EmailService>();
        Configuration.Default.ApiKey.Add("api-key", configuration["SendingBlue_api_key"]);
    }
}