using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.DAL.TransferApiDAL.TransferLogRepoDAL;
using MicroserviceRabbitMQ.Entities.TransferApiEntities.Transfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.BLL.TransferApiBLL.TransferLogRepoBLL
{
    public class TransferLogBLL : ITransferLogBLL
    {
        private readonly ITransferLogDAL _transferLog;
        private readonly IEventBus _eventBus;
        public TransferLogBLL(ITransferLogDAL transferLog, IEventBus eventBus)
        {
            _transferLog = transferLog;
            _eventBus = eventBus;
        }

        public void AddTransferLog(TransferLog transferLog)
        {
            _transferLog.AddTransferLog(transferLog);
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferLog.GetTransferLogs();
        }
    }
}
