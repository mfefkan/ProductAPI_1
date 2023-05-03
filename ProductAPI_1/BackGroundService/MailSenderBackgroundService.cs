using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;
using OrderAPI.Models.Entities;

namespace ProductAPI_1.BackGroundService
{
    public class MailSenderBackgroundService : BackgroundService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly string _queueName = "SendMail";

        public MailSenderBackgroundService()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: _queueName,
                                  durable: false,
                                  exclusive: false,
                                  autoDelete: false,
                                  arguments: null);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += async (model, ea) =>
            {
                byte[] body = ea.Body.ToArray();
                string message = Encoding.UTF8.GetString(body);

                Order newOrder = JsonConvert.DeserializeObject<Order>(message);
                string customerEmail = newOrder.CustomerEmail;

                //Test öncesi aşağıdaki mail ve sunucu verilerini düzenleyiniz.

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("email@....com");
                mailMessage.To.Add(customerEmail);
                mailMessage.Subject = "Siparişiniz başarı ile oluşturuldu!";
                mailMessage.Body = "Siparişiniz başarı ile oluşturuldu. Teşekkür ederiz.";


                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com"; 
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("email@....com", "password"); 
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                _channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };

            _channel.BasicConsume(queue: _queueName,
                                  autoAck: false,
                                  consumer: consumer);

            await Task.CompletedTask;
        }

        public override void Dispose()
        {
            _channel.Close();
            _connection.Close();
            base.Dispose();
        }
    }
}