using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Consultant_Id { get; set; }
        public int Ward_Id { get; set; }

        [ForeignKey("Consultant_Id")]
        public Consultant Consultant { get; set; }
        [ForeignKey("Ward_Id")]
        public Ward Ward { get; set; }


        public ICollection<Patient_Nurse_Drug> patient_Nurse_Drugs { get; set; }

        public ICollection<Patient_Consultant_Examine> patient_Consultant_Examines { get; set; }

    }
}
