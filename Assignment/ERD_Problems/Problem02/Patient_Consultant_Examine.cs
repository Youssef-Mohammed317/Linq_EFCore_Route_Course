using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Patient_Consultant_Examine
    {
        public int Patient_Id { get; set; }
        public int Consultant_Id { get; set; }
        public DateTime Examine_Date { get; set; }

        [ForeignKey("Patient_Id")]
        public Patient Patient { get; set; }
        [ForeignKey("Consultant_Id")]
        public Consultant Consultant { get; set; }
    }
}
