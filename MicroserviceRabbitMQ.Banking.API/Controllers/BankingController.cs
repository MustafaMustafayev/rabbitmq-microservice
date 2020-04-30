using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviceRabbitMQ.BLL.AccountRepoBLL;
using MicroserviceRabbitMQ.Entities.Banking;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitMQ.Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountBLL _account;
        public BankingController(IAccountBLL account)
        {
            _account = account;
        }

        [HttpGet("accounts")]
        public IActionResult Accounts()
        {
            return Ok(_account.GetAccounts());
        }

        [HttpPost("post")]
        public IActionResult Post(AccountTransfer accountTransfer)
        {
            _account.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}