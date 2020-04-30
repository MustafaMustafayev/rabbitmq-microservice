using MicroserviceRabbitMQ.Entities.TransferApiEntities.Transfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.BLL.TransferApiBLL.TransferLogRepoBLL
{
    public interface ITransferLogBLL
    {
        IEnumerable<TransferLog> GetTransferLogs();

        void AddTransferLog(TransferLog transferLog);
    }
}
