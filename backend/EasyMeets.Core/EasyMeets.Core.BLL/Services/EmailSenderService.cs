using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
using EasyMeets.RabbitMQ.Interface;
using Newtonsoft.Json;

namespace EasyMeets.Core.BLL.Services;

public class EmailSenderService : IEmailSenderService
{
    private readonly IProducerService _producerService;

    public EmailSenderService(IProducerService producerService)
    {
        _producerService = producerService;
    }

    public void Send(EmailDto email)
    {
        var message = JsonConvert.SerializeObject(email);
        
        _producerService.Send(message, "application/json");
    }
}