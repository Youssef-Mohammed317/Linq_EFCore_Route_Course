using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem05
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Department_Id { get; set; }

        // Navigation property
        [ForeignKey("Department_Id")]
        public Department Department { get; set; }
    }
}
