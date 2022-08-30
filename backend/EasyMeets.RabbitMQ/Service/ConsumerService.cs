using EasyMeets.RabbitMQ.Interface;
using EasyMeets.RabbitMQ.Settings;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace EasyMeets.RabbitMQ.Service
{
    public class ConsumerService : IConsumerService
    {
        private readonly IConnection _connection;
        private readonly IModel _channelReceive;
        private readonly string _receiveNotificationFrom;

        public ConsumerService(IConnection connection, ConsumerSettings settings)
        {
            _receiveNotificationFrom = settings.QueueName;

            _connection = connection;
            _channelReceive = _connection.CreateModel();
            _channelReceive.QueueDeclare(
                    queue: _receiveNotificationFrom,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

            _channelReceive.QueueBind(settings.QueueName, settings.ExchangeName, settings.RoutingKey);

            _channelReceive.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
        }

        public void ListenQueue()
        {
            var consumer = new EventingBasicConsumer(_channelReceive);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                _channelReceive.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };

            _channelReceive.BasicConsume(queue: _receiveNotificationFrom,
                                 autoAck: false,
                                 consumer: consumer);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_connection is not null)
                {
                    _connection.Dispose();
                    _channelReceive.Dispose();
                }
            }
        }
    }
}
