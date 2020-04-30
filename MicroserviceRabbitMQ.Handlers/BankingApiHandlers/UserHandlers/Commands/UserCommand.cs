using MicroserviceRabbitMQ.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.Handlers.UserHandlers.Commands
{
    public class UserCommand : Command
    {
        public int UserId { get; protected set; }
        public string UserName { get; protected set; }
    }
}
