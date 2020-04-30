using MicroserviceRabbitMQ.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.Handlers.UserHandlers.Events
{
    public class UserCreatedEvent : Event
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }

        public UserCreatedEvent(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

    }
}
