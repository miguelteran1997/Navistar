using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NAVISTAR1.Data;

namespace NAVISTAR1.Pages.Own.Dept
{
    public class CreateModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public CreateModel(NAVISTAR1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Deapartment Deapartment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Deapartment.Add(Deapartment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}