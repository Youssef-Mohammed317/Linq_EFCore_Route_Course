using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Song> Songs { get; set; }

    }
}
