using ShopJoaoDias.MessageBus;

namespace ShopJoaoDias.OrderAPI.RabbitMqSender
{
    public interface IRabbitMqMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}
