using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Employee
    {
        public int Id { get; set; } // primary key by convention
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
}
