using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem01
{
    internal class Phones
    {
        public int Airline_Id { get; set; }
        public int Phone_Number { get; set; }

        [ForeignKey("Airline_Id")]
        public Airline Airline { get; set; }

    }
}
