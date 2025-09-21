using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Context02 : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ERD_Problem02_DB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrugBrand>().HasKey(db => new { db.DrugCode, db.BrandName });
            modelBuilder.Entity<Patient_Nurse_Drug>().HasKey(pnd => new { pnd.PatientId, pnd.NurseNumber, pnd.DrugCode, pnd.Date, pnd.Time });
            modelBuilder.Entity<Patient_Consultant_Examine>().HasKey(pce => new { pce.Patient_Id, pce.Consultant_Id, pce.Examine_Date });
        }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugBrand> DrugBrands { get; set; }
        public DbSet<Patient_Nurse_Drug> Patient_Nurse_Drugs { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Patient_Consultant_Examine> Patient_Consultant_Examines { get; set; }





    }
}
