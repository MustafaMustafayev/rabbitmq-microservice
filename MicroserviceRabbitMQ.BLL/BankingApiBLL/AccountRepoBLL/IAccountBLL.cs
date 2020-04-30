using MicroserviceRabbitMQ.Entities.Banking;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.BLL.AccountRepoBLL
{
    public interface IAccountBLL
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
