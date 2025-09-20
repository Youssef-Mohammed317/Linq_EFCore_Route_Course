using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        [AllowNull]
        public int? Grade { get; set; }


        [ForeignKey(nameof(StudentId))]
        public Student? student { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course? course { get; set; }
    }
}
