using MicroserviceRabbitMQ.Consume.API.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Consume.API.Methods
{
    public class ConsumeUser
    {
        public async Task ConsumeUserFromQueue()
        {
            var eventName = "UserCreatedEvent";
            var factory = new ConnectionFactory() { HostName = "localhost", DispatchConsumersAsync = true };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            channel.QueueDeclare(eventName, true, false, false, null);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.Received += Consumer_Received;
            channel.BasicConsume(eventName, true, consumer);
        }

        // invoke business process from here
        private async Task Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var eventName = e.RoutingKey;
            var message = Encoding.UTF8.GetString(e.Body);
            User user = JsonConvert.DeserializeObject<User>(message);
        }
    }
}
