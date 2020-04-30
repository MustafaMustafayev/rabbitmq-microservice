using MediatR;
using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.Handlers.UserHandlers.Commands;
using MicroserviceRabbitMQ.Handlers.UserHandlers.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Handlers.UserHandlers.CommandHandlers
{
    public class UserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IEventBus _eventBus;
        public UserCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // publish event to RabbitMQ
            _eventBus.Publish(new UserCreatedEvent(request.UserId, request.UserName));

            return Task.FromResult(true);
        }
    }
}
