using Ecoit.Data;
using Ecoit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoit.Infra
{
    public class dbAccess : IdbAccess
    {
        public User GetUser(User user, DataContext bdd)
        {
            return (from p in bdd.User
                    select new User
                    {
                        mail = user.mail,
                        password = p.password
                    }).First();
        }

        // TODO POST
        // TODO PUT
        // TODO delete
    }
}
