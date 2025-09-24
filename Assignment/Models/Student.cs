using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string? FName { get; set; }
        [Required, MaxLength(50)]
        public string? LName { get; set; }
        [Required, MaxLength(50)]
        public string? Address { get; set; }
        [Required]
        public int Age { get; set; }
        public int DepartmentId { get; set; }


        [ForeignKey(nameof(DepartmentId))]
        public virtual Department? department { get; set; }

        public virtual ICollection<Student_Course> StudentCourses { get; set; }
    }
}
