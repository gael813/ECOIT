using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ecoit.Data;
using Ecoit.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecoit.Pages.Instructor.Formations
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Ecoit.Data.DataContext _context;

        public CreateModel(Ecoit.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Formation Formation { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Formation.Add(Formation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
