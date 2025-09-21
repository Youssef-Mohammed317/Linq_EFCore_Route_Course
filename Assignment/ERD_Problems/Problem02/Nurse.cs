using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Nurse
    {
        [Key]
        public int NurseNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Ward_Id { get; set; }

        [ForeignKey("Ward_Id")]
        public Ward Ward { get; set; }

        public ICollection<Patient_Nurse_Drug> patient_Nurse_Drugs { get; set; }
    }
}
