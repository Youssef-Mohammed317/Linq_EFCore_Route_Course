using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem04
{
    internal class Property
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Code { get; set; }
        public int SalesOfficeNubmer { get; set; }

        // Navigation property
        [ForeignKey("SalesOfficeNubmer")]
        public Sales_Office SalesOffice { get; set; }

        public ICollection<Property_Owner> PropertyOwners { get; set; }
    }
}
