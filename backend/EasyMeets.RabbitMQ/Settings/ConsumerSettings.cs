namespace EasyMeets.RabbitMQ.Settings
{
    public class ConsumerSettings
    {
        public string? ExchangeName { get; set; }
        public string? ExchangeType { get; set; }
        public string? RoutingKey { get; set; }
        public string QueueName { get; set; } = string.Empty;
        public bool SequentialFetch { get; set; } = true;
        public bool AutoAcknowledge { get; set; } = false;
    }
}
