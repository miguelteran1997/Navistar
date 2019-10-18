using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NAVISTAR1.Data;

namespace NAVISTAR1.Pages.Own.Dept
{
    public class EditModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public EditModel(NAVISTAR1.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Deapartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeapartmentExists(Deapartment.DID))
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

        private bool DeapartmentExists(int id)
        {
            return _context.Deapartment.Any(e => e.DID == id);
        }
    }
}
