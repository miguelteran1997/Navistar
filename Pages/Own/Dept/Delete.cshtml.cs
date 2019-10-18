using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAVISTAR1.Data;

namespace NAVISTAR1.Pages.Own.Dept
{
    public class DeleteModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public DeleteModel(NAVISTAR1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Deapartment Deapartment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deapartment = await _context.Deapartment.FirstOrDefaultAsync(m => m.DID == id);

            if (Deapartment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deapartment = await _context.Deapartment.FindAsync(id);

            if (Deapartment != null)
            {
                _context.Deapartment.Remove(Deapartment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
