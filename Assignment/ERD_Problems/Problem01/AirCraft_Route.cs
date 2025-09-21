using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem01
{
    internal class AirCraft_Route
    {
        public int AirCraft_Id { get; set; }
        public int Route_Id { get; set; }
        public int Number_of_Passengers { get; set; }
        public int Price_per_Passenger { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public int Duration { get; set; }

        [ForeignKey(nameof(AirCraft_Id))]
        public AirCraft AirCraft { get; set; }
        [ForeignKey(nameof(Route_Id))]
        public Route Route { get; set; }

    }
}
