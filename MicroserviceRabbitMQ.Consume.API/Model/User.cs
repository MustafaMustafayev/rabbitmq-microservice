using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Consume.API.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
