using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    [Table("Courses", Schema = "dbo")]
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required, MaxLength(50)]
        public string? Name { get; set; }
        [AllowNull]
        public string? Description { get; set; }
        public int TopicId { get; set; }

        [ForeignKey(nameof(TopicId))]
        public Topic? topic { get; set; }
    }
}
