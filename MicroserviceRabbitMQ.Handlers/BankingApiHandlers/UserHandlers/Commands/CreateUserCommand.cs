using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.Handlers.UserHandlers.Commands
{
    public class CreateUserCommand : UserCommand
    {
        public CreateUserCommand(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }
    }
}
