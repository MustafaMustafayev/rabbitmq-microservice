using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.Entities.User;
using MicroserviceRabbitMQ.Handlers.UserHandlers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.BLL.UserRepoBLL
{
    public class UserBLL : IUserBLL
    {
        private readonly IEventBus _eventBus;

        public UserBLL(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void PostUsersToRabbitMQ(User user)
        {
            var createUserCommand = new CreateUserCommand(
                user.UserId,
                user.UserName
                );

            _eventBus.SendCommand(createUserCommand);
        }
    }
}
