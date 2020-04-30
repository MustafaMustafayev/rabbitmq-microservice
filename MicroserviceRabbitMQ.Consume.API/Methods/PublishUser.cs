using MicroserviceRabbitMQ.Consume.API.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Consume.API.Methods
{
    public class PublishUser
    {
      public void Publish(User user)
        {
            var eventName = "UserCreatedEvent";
            var hostName = "localhost";
            var factory = new ConnectionFactory() { HostName = hostName };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(eventName, true, false, false, null);
                    var message = user;
                    var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
                    channel.BasicPublish("", eventName, null, body);
                }
            }
        }
    }
}
