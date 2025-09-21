using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem05
{
    internal class Course_Instructor
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public string Evalution { get; set; }

        // Navigation properties
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }

    }
}
