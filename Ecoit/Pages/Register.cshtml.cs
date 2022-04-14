using Ecoit.Data;
using Ecoit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Ecoit.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<RegisterModel> _logger;
        DataContext dataContext;

        public RegisterModel(ILogger<RegisterModel> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public System.Security.Claims.ClaimsPrincipal GetUser()
        {
            return User;
        }

        public void OnGet(string email, string password, string pseudo)
        {
            if (email != string.Empty && password != string.Empty && pseudo != string.Empty)
            {
                var users = new User() { login = pseudo, password = password, mail = email };
                dataContext.User.Add(users);
                dataContext.SaveChanges();
            }
        }
    }
}
