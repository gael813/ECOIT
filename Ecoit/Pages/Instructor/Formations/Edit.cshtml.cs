using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecoit.Data;
using Ecoit.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecoit.Pages.Instructor.Formations
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly Ecoit.Data.DataContext _context;

        public EditModel(Ecoit.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Formation Formation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Formation = await _context.Formation.FirstOrDefaultAsync(m => m.FormID == id);

            if (Formation == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Formation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormationExists(Formation.FormID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FormationExists(int id)
        {
            return _context.Formation.Any(e => e.FormID == id);
        }
    }
}
