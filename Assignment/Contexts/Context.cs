using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Contexts
{
    public class Context : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=.;Initial Catalog=RouteContext;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<Course_Instructor>().HasKey(ci => new { ci.CourseId, ci.InstructorId });
        }

    }
}
