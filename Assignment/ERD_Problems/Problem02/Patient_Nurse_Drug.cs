using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Patient_Nurse_Drug
    {
        public int PatientId { get; set; }
        public int NurseNumber { get; set; }
        public int DrugCode { get; set; }
        public DateOnly Date { get; set; }
        public string Dosage { get; set; }
        public DateTime Time { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
        [ForeignKey("NurseNumber")]
        public Nurse Nurse { get; set; }
        [ForeignKey("DrugCode")]
        public Drug Drug { get; set; }

    }
}
