using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem01
{
    internal class AirCraft
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int Major_Pilot_Id { get; set; }
        public int Assistant_Pilot_Id { get; set; }
        public int Hostess01_Id { get; set; }
        public int Hostess02_Id { get; set; }
        public int Airline_Id { get; set; }

        [ForeignKey(nameof(Airline_Id))]
        public Airline Airline { get; set; }
        [ForeignKey(nameof(Major_Pilot_Id))]
        public Pilot Major_Pilot { get; set; }
        [ForeignKey(nameof(Assistant_Pilot_Id))]
        public Pilot Assistant_Pilot { get; set; }
        [ForeignKey(nameof(Hostess01_Id))]
        public Hostess Hostess01 { get; set; }
        [ForeignKey(nameof(Hostess02_Id))]
        public Hostess Hostess02 { get; set; }

    }
}
