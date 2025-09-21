using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class Drug
    {
        [Key]
        public int Code { get; set; }
        public string Dosage { get; set; }

        public ICollection<DrugBrand> DrugBrands { get; set; }

        public ICollection<Patient_Nurse_Drug> patient_Nurse_Drugs { get; set; }

    }
}
