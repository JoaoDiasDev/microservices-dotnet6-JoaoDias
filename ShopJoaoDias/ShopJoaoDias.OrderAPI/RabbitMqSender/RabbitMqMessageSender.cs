using Microsoft.AspNetCore.Connections;
using RabbitMQ.Client;
using ShopJoaoDias.MessageBus;
using ShopJoaoDias.OrderAPI.Messages;
using System.Text;
using System.Text.Json;

namespace ShopJoaoDias.OrderAPI.RabbitMqSender
{
    public class RabbitMqMessageSender : IRabbitMqMessageSender
    {
        private readonly string _hostName;
        private readonly string _password;
        private readonly string _userName;
        private IConnection _connection;

        public RabbitMqMessageSender()
        {
            _hostName = "localhost";
            _password = "admin";
            _userName = "admin";
        }

        public void SendMessage(BaseMessage message, string queueName)
        {
            if (!ConnectionExists()) return;
            using var channel = _connection.CreateModel();
            channel.QueueDeclare(queue: queueName, false, false, false, arguments: null);
            var body = GetMessageAsByteArray(message);
            channel.BasicPublish(
                exchange: "", routingKey: queueName, basicProperties: null, body: body);
        }

        private static byte[] GetMessageAsByteArray(BaseMessage message)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = JsonSerializer.Serialize((PaymentVO)message, options);
            var body = Encoding.UTF8.GetBytes(json);
            return body;
        }

        private bool ConnectionExists()
        {
            if (_connection == null)
            {
                CreateConnection();
            }
            return _connection != null;
        }

        private void CreateConnection()
        {
            try
            {
                var factory = new ConnectionFactory
                {
                    HostName = _hostName,
                    UserName = _userName,
                    Password = _password
                };
                _connection = factory.CreateConnection();
            }
            catch (Exception e)
            {
                throw new ConnectionAbortedException(e.Message);
            }
        }
    }
}
