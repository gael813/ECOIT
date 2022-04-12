using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecoit.Data;
using Ecoit.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecoit.Pages.Instructor.Formations
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Ecoit.Data.DataContext _context;

        public IndexModel(Ecoit.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Formation> Formation { get;set; }

        public async Task OnGetAsync()
        {
            Formation = await _context.Formation.ToListAsync();
        }
    }
}
