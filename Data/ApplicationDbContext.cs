using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NAVISTAR1.Data;

namespace NAVISTAR1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NAVISTAR1.Data.Employee> Employee { get; set; }
        public DbSet<NAVISTAR1.Data.Owner> Owner { get; set; }
        public DbSet<NAVISTAR1.Data.Deapartment> Deapartment { get; set; }
    }
}
