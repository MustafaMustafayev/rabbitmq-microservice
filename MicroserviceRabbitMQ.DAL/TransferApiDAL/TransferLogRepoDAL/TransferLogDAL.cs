using MicroserviceRabbitMQ.DAL.TransferApiDAL.DatabaseContext;
using MicroserviceRabbitMQ.Entities.TransferApiEntities.Transfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.DAL.TransferApiDAL.TransferLogRepoDAL
{
    public class TransferLogDAL : ITransferLogDAL
    {
        private readonly TransferDbContext _ctx;
        public TransferLogDAL(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddTransferLog(TransferLog transferLog)
        {
            _ctx.TransferLogs.Add(transferLog);
            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
