namespace EasyMeets.RabbitMQ.Interface
{
    public interface IConsumerService : IDisposable
    {
        public void ListenQueue();
    }
}
