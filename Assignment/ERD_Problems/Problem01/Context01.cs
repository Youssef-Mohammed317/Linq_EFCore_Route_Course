using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem01
{
    internal class Context01 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ERD_Problem01;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirCraft_Route>()
                .HasKey(ar => new { ar.AirCraft_Id, ar.Route_Id });
            modelBuilder.Entity<Phones>()
                .HasKey(p => new { p.Airline_Id, p.Phone_Number });
            modelBuilder.Entity<Qualifications>()
                .HasKey(q => new { q.Employee_Id, q.Qualification });
        }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<AirCraft_Route> AirCraft_Routes { get; set; }
        public DbSet<Phones> Phones { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Qualifications> Qualifications { get; set; }
        public DbSet<Hostess> Hostesses { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

    }
}
