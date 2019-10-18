using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAVISTAR1.Data;

namespace NAVISTAR1.Pages.Own
{
    public class DetailsModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public DetailsModel(NAVISTAR1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Owner Owner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Owner = await _context.Owner.FirstOrDefaultAsync(m => m.OID == id);

            if (Owner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
