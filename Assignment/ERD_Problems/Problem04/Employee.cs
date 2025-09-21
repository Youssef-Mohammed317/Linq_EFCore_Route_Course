using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem04
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SalesOfficeNumber { get; set; }

        // Navigation property
        [ForeignKey("SalesOfficeNumber")]
        public Sales_Office SalesOffice { get; set; }
    }
}
