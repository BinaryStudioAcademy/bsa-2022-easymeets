namespace EasyMeets.RabbitMQ.Interface
{
    public interface IProducerService
    {
        void Send(string message, string? type);
    }
}
