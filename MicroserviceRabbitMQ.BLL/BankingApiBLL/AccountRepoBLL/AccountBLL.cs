using MicroserviceRabbitMQ.Core.Bus;
using MicroserviceRabbitMQ.DAL.BankinRepoDAL;
using MicroserviceRabbitMQ.DAL.DatabaseContext;
using MicroserviceRabbitMQ.Entities.Banking;
using MicroserviceRabbitMQ.Handlers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.BLL.AccountRepoBLL
{
    public class AccountBLL : IAccountBLL
    {
        private readonly IAccountDAL _banking;
        private readonly IEventBus _eventBus;
        public AccountBLL(IAccountDAL banking, IEventBus eventBus)
        {
            _banking = banking;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _banking.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
                );

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
