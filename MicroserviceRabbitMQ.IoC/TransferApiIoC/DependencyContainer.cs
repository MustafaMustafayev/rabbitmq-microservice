using MediatR;
using MicroserviceRabbitMQ.BLL.TransferApiBLL.TransferLogRepoBLL;
using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.DAL.TransferApiDAL.DatabaseContext;
using MicroserviceRabbitMQ.DAL.TransferApiDAL.TransferLogRepoDAL;
using MicroserviceRabbitMQ.Handlers.TransferApiHandlers.TransferLogHandlers.EventHandler;
using MicroserviceRabbitMQ.Handlers.TransferApiHandlers.TransferLogHandlers.Events;
using MicroserviceRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.IoC.TransferApiIoC
{

    // subscribing to queue
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // when you subscribe to queue
            services.AddSingleton<IEventBus, RabbitMQBus>(sp => {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            // subscribing
            services.AddTransient<TransferLogEventHandler>();

            services.AddTransient<ITransferLogBLL, TransferLogBLL>();
            services.AddTransient<ITransferLogDAL, TransferLogDAL>();

            // register event handler
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferLogEventHandler>();

        }
    }
}
