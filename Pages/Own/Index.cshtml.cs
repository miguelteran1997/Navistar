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
    public class IndexModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public IndexModel(NAVISTAR1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Owner> Owner { get;set; }

        public async Task OnGetAsync()
        {
            Owner = await _context.Owner.ToListAsync();
        }
    }
}
