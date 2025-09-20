using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    [Table("Course_Inst", Schema = "dbo")]
    internal class Course_Instructor
    {

        public int InstructorId { get; set; }

        public int CourseId { get; set; }
        [Required]
        public int Evaluate { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Instructor? instructor { get; set; }
        [ForeignKey(nameof(InstructorId))]
        public Course? course { get; set; }
    }
}
