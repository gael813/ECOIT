using Ecoit.Data;
using Ecoit.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoit.Infra
{
    interface IdbAccess
    {
        public User GetUser(User user, DataContext bdd);
    }
}
