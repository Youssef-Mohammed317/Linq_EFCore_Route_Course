using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Musician
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string street { get; set; }
        public int Phone_Number { get; set; }

        public ICollection<Album> Albums { get; set; }
        public ICollection<Musican_Instrument> MusicianInstruments { get; set; }
        public ICollection<Song_Musican> Song_Musicans { get; set; }


    }
}
