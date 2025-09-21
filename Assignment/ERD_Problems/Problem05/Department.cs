using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem05
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public DateTime HiringDate { get; set; }

        // Navigation property
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }

        [InverseProperty("Department")]
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
