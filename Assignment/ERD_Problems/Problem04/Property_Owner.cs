using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem04
{
    internal class Property_Owner
    {
        public int PropertyId { get; set; }
        public int OwnerId { get; set; }
        public int Percent { get; set; }

        // Navigation properties
        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
    }
}
