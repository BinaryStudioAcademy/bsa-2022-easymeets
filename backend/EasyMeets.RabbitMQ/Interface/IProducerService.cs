namespace EasyMeets.RabbitMQ.Interface
{
    public interface IProducerService : IDisposable
    {
        void Send(string message, string? type);
    }
}
