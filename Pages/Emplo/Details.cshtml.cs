using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAVISTAR1.Data;

namespace NAVISTAR1.Pages.Emplo
{
    public class DetailsModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public DetailsModel(NAVISTAR1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
