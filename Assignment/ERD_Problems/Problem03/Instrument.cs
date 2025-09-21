using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Instrument
    {
        [Key]
        public string Name { get; set; }
        public int Key { get; set; }

        public ICollection<Musican_Instrument> MusicianInstruments { get; set; }
    }
}
