using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem01
{
    internal class Qualifications
    {

        public int Employee_Id { get; set; }
        public string Qualification { get; set; }

        [ForeignKey(nameof(Employee_Id))]
        public Employee Employee { get; set; }
    }
}
