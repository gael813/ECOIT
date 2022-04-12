using Ecoit.Data;
using Ecoit.Infra;
using Ecoit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoit.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext dataContext;
        IdbAccess access;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
            access = new dbAccess();
        }

        public void OnGet()
        {
            /*
            User admin = new User() { mail = "admin@admin.fr", password="admin" };
            dataContext.User.Add(admin);
            dataContext.SaveChanges();
            */
        }
    }
}
