using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ShopJoaoDias.PaymentAPI.Messages;
using ShopJoaoDias.PaymentAPI.RabbitMqSender;
using ShopJoaoDias.PaymentProcessor;
using System.Text;
using System.Text.Json;

namespace ShopJoaoDias.PaymentAPI.MessageConsumer
{
    public class RabbitMqPaymentConsumer : BackgroundService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly IProcessPayment _processPayment;
        private readonly IRabbitMqMessageSender _rabbitMqMessageSender;

        public RabbitMqPaymentConsumer(IProcessPayment processPayment, IRabbitMqMessageSender rabbitMqMessageSender)
        {
            _processPayment = processPayment;
            _rabbitMqMessageSender = rabbitMqMessageSender;
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin",
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: "order_payment_process_queue", false, false, false, arguments: null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (channel, evt) =>
            {
                var content = Encoding.UTF8.GetString(evt.Body.ToArray());
                var vo = JsonSerializer.Deserialize<PaymentMessage>(content);
                ProcessPayment(vo).GetAwaiter().GetResult();
                _channel.BasicAck(evt.DeliveryTag, false);
            };
            _channel.BasicConsume("order_payment_process_queue", false, consumer);
            return Task.CompletedTask;
        }

        private async Task ProcessPayment(PaymentMessage vo)
        {
            var result = _processPayment.PaymentProcessor();

            UpdatePaymentResultMessage paymentResult = new()
            {
                Status = result,
                OrderId = vo.OrderId,
                Email = vo.Email
            };

            try
            {
                _rabbitMqMessageSender.SendMessage(paymentResult);
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException(e.Message);
            }
        }
    }
}
