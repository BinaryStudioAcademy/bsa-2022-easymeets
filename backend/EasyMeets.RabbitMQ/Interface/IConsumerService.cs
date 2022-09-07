using RabbitMQ.Client.Events;

namespace EasyMeets.RabbitMQ.Interface
{
    public interface IConsumerService : IDisposable
    {
        void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler);
        void SetAcknowledge(ulong deliveryTag, bool processed);
    }
}
