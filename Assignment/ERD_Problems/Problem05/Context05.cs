using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem05
{
    internal class Context05 : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ERD_Problem05;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Instructor>()
                .HasKey(ci => new { ci.CourseId, ci.InstructorId });
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
