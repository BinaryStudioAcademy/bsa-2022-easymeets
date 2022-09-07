using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.RabbitMQ.Interface;

namespace EasyMeets.Core.BLL.Services
{
    public class InformQueueService : IInformQueueService
    {
        private readonly IProducerService _producer;

        public InformQueueService(IProducerService producer, IConsumerService consumer)
        {
            _producer = producer;
        }

        public void InformEveryone(string message)
        {
            _producer.Send(message, null);
        }
    }
}
