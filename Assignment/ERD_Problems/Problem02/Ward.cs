using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Ward
    {
        [Key]
        public int Ward_Id { get; set; }
        public string Ward_Name { get; set; }
        public int Nurse_Number { get; set; }

        [ForeignKey("Nurse_Number")]
        public Nurse Nurse { get; set; }

        [InverseProperty("Ward")]
        public ICollection<Nurse> Nurses { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}
