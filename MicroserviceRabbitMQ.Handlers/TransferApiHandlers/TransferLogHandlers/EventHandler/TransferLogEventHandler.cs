using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.DAL.TransferApiDAL.TransferLogRepoDAL;
using MicroserviceRabbitMQ.Entities.TransferApiEntities.Transfer;
using MicroserviceRabbitMQ.Handlers.TransferApiHandlers.TransferLogHandlers.Events;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Handlers.TransferApiHandlers.TransferLogHandlers.EventHandler
{
    public class TransferLogEventHandler : IEventHandler<TransferCreatedEvent>
    {
        //   private readonly ITransferLogBLL  _transferLog;
        private readonly ITransferLogDAL _transferLog;
        public TransferLogEventHandler(ITransferLogDAL transferLog)
        {
            _transferLog = transferLog;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferLog.AddTransferLog(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount =   @event.To,
                TransferAmount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}
