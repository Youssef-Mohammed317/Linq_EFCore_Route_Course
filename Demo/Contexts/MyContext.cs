using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    public class MyContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        public MyContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RouteEFSession01;TrustServerCertificate=True;Trusted_Connection=True");
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=RouteEFSession01;TrustServerCertificate=True;IntegratedSecurity=Ture");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
