using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string? Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
