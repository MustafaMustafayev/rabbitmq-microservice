using MicroserviceRabbitMQ.Entities.TransferApiEntities.Transfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.DAL.TransferApiDAL.TransferLogRepoDAL
{
    public interface ITransferLogDAL
    {
        IEnumerable<TransferLog> GetTransferLogs();

        void AddTransferLog(TransferLog transferLog);
    }
}
