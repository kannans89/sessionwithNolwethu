using EFConsoleApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp
{
    internal class OrganizationDbContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=OrganizationDB;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyOrgnization;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }

    }
}
