using EasyMeets.RabbitMQ.Interface;
using EasyMeets.Watcher.BLL.Interfaces;

namespace EasyMeets.Watcher.BLL.Queries
{
    public class WebHookNotifier : IWebHookNotifier
    {
        private readonly IProducerService _producer;

        public WebHookNotifier(IProducerService producer)
        {
            _producer = producer;
        }

        public void NotifyCalendarChanges(string message)
        {
            try
            {
                _producer.Send(message, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
