using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string? Name { get; set; }
        [AllowNull]
        public int? InstructorId { get; set; }
        [Required]
        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(InstructorId))]
        public virtual Instructor? Instructor { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
