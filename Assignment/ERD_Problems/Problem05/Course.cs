using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem05
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int Topic_Id { get; set; }

        // Navigation property
        [ForeignKey("Topic_Id")]
        public Topic Topic { get; set; }

        public ICollection<Course_Instructor> CourseInstructors { get; set; }
        public ICollection<Student_Course> StudentCourses { get; set; }
    }
}
