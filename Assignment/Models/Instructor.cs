using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Required, MaxLength(100)]
        public string? Address { get; set; }
        [Required]
        public decimal HourRate { get; set; }
        [AllowNull]
        public decimal? Bonus { get; set; }
        public int DepartmentId { get; set; }
    }
}
