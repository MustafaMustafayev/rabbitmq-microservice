using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviceRabbitMQ.Consume.API.Methods;
using MicroserviceRabbitMQ.Consume.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitMQ.Consume.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult ConsumeUser()
        {
            ConsumeUser consume = new ConsumeUser();
            return Ok(consume.ConsumeUserFromQueue());
        }

        [HttpPost]
        public IActionResult PublishUser(User user)
        {
            PublishUser publish = new PublishUser();
            publish.Publish(user);
            return Ok("Published");
        }
    }
}