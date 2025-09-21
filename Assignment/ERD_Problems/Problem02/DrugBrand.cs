using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem02
{
    internal class DrugBrand
    {

        public int DrugCode { get; set; }
        public string BrandName { get; set; }

        [ForeignKey("DrugCode")]
        public Drug Drug { get; set; }
    }
}
