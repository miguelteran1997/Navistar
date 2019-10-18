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
    public class IndexModel : PageModel
    {
        private readonly NAVISTAR1.Data.ApplicationDbContext _context;

        public IndexModel(NAVISTAR1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
