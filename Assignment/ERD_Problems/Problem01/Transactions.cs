using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem01
{
    internal class Transactions
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Airline_Id { get; set; }

        // Navigation property
        [ForeignKey(nameof(Airline_Id))]
        public Airline Airline { get; set; }
    }
}
