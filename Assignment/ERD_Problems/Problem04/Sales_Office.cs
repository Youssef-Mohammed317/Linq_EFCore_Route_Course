using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem04
{
    internal class Sales_Office
    {
        [Key]
        public int Number { get; set; }
        public string Location { get; set; }
        public int EmployeeId { get; set; }

        // Navigation properties
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [InverseProperty("SalesOffice")]
        public ICollection<Employee> Employees { get; set; }

        public ICollection<Property> Properties { get; set; }


    }
}
