using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Employee
    {
        //EmpName
        //    Age": 30,
        //    Email": "sameh @gmail.com",
        //    Salary": 9000,
        //    PhoneNumber": "0123456789",
        //    EmpAddress": {
        //     "City": "Cairo",
        //     "Country": "Egypt",
        //     "Street": "El Tahrir"
        //    ,
        //    DepartmentId": 10

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string EmpAddress_City { get; set; }
        public string EmpAddress_Country { get; set; }
        public string EmpAddress_Street { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
