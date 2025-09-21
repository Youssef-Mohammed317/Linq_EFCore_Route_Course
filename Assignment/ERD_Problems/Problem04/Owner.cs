using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem04
{
    internal class Owner
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Property_Owner> PropertyOwners { get; set; }

    }
}
