using ShopJoaoDias.MessageBus;

namespace ShopJoaoDias.PaymentAPI.RabbitMqSender
{
    public interface IRabbitMqMessageSender
    {
        void SendMessage(BaseMessage baseMessage);
    }
}
