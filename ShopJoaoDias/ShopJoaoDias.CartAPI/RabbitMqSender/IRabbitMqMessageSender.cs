using ShopJoaoDias.MessageBus;

namespace ShopJoaoDias.CartAPI.RabbitMqSender
{
    public interface IRabbitMqMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}
