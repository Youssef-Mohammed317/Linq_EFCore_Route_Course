using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem05
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public int Department_Id { get; set; }

        // Navigation property
        [ForeignKey("Department_Id")]
        public Department Department { get; set; }

        public ICollection<Course_Instructor> CourseInstructors { get; set; }
    }
}
