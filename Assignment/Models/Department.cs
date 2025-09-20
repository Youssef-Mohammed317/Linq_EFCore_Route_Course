using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string? Name { get; set; }
        [AllowNull]
        public int? InstructorId { get; set; }
        [Required]
        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(InstructorId))]
        //[InverseProperty(nameof(Instructor.Department))]
        public Instructor? Instructor { get; set; }
    }
}
