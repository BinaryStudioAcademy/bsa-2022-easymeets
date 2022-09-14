using System.Text;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using EasyMeets.RabbitMQ.Interface;
using EasyMeets.RabbitMQ.Service;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;

namespace EasyMeets.Emailer.WebAPI.HostedServices;

public class EmailQueueListener : IHostedService
{
    private readonly IEmailService _emailService;
    private readonly IConsumerService _consumerService;

    public EmailQueueListener(IEmailService emailService, IConsumerService consumerService)
    {
        _emailService = emailService;
        _consumerService = consumerService;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _consumerService.ListenAsync(EmailReceived);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _consumerService.Dispose();

        return Task.CompletedTask;
    }

    private async Task EmailReceived(object sender, BasicDeliverEventArgs args)
    {
        var emailDto = DeserializeEmailDto(args.Body.ToArray());

        if (emailDto is null)
        {
            _consumerService.SetAcknowledge(args.DeliveryTag, true);

            return;
        }

        try
        {
            await _emailService.SendEmailAsync(emailDto.Recipient, emailDto.Body, emailDto.Subject);
        }
        finally
        {
            _consumerService.SetAcknowledge(args.DeliveryTag, true);
        }
    }

    private static EmailDto DeserializeEmailDto(byte[] bytes)
    {
        var json = Encoding.UTF8.GetString(bytes);

        return JsonConvert.DeserializeObject<EmailDto>(json);
    }
}