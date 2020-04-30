using MicroserviceRabbitMQ.DAL.DatabaseContext;
using MicroserviceRabbitMQ.Entities.Banking;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.DAL.BankinRepoDAL
{
    public class AccountDAL : IAccountDAL
    {
        private readonly BankingDbContext _ctx;
        public AccountDAL(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
