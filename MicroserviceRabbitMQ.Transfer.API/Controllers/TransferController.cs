using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviceRabbitMQ.BLL.TransferApiBLL.TransferLogRepoBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitMQ.Transfer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferLogBLL _transferLog;
        public TransferController(ITransferLogBLL transferLog)
        {
            _transferLog = transferLog;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_transferLog.GetTransferLogs());
        }

    }
}