using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Musican_Instrument
    {
        public int MusicianId { get; set; }
        public string Instrument_Name { get; set; }

        // Navigation properties
        [ForeignKey("Instrument_Name")]
        public Instrument Instrument { get; set; }
        [ForeignKey("MusicianId")]
        public Musician Musician { get; set; }
    }
}
