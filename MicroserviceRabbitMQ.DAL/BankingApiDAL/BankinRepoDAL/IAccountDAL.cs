using MicroserviceRabbitMQ.Entities.Banking;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.DAL.BankinRepoDAL
{
    public interface IAccountDAL
    {
        IEnumerable<Account> GetAccounts();
    }
}
