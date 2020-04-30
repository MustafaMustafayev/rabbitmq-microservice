using MicroserviceRabbitMQ.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.BLL.UserRepoBLL
{
    public interface IUserBLL
    {
        void PostUsersToRabbitMQ(User user);
    }
}
