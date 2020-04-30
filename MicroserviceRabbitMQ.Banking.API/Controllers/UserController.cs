using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviceRabbitMQ.BLL.UserRepoBLL;
using MicroserviceRabbitMQ.Entities.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitMQ.Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBLL _user;
        public UserController(IUserBLL user)
        {
            _user = user;
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            _user.PostUsersToRabbitMQ(user);
            return Ok(user);
        }
    }
}