using MediatR;
using MicroserviceRabbitMQ.BLL.AccountRepoBLL;
using MicroserviceRabbitMQ.BLL.UserRepoBLL;
using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.DAL.BankinRepoDAL;
using MicroserviceRabbitMQ.DAL.DatabaseContext;
using MicroserviceRabbitMQ.Handlers.CommandHandlers;
using MicroserviceRabbitMQ.Handlers.Commands;
using MicroserviceRabbitMQ.Handlers.UserHandlers.CommandHandlers;
using MicroserviceRabbitMQ.Handlers.UserHandlers.Commands;
using MicroserviceRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.IoC.BankingApiIoC
{

    // pushing message to queue
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.AddTransient<IAccountDAL, AccountDAL>();
            services.AddTransient<IAccountBLL, AccountBLL>();
            services.AddDbContext<BankingDbContext>();

            // register transfer handler
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // register user objects
            services.AddTransient<IUserBLL, UserBLL>();
            services.AddTransient<IRequestHandler<CreateUserCommand, bool>, UserCommandHandler>();

        }
    }
}
