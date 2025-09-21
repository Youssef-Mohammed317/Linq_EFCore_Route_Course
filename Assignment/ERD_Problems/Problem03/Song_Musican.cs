using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Song_Musican
    {
        public string Song_Title { get; set; }
        public int MusicianId { get; set; }

        // Navigation properties
        [ForeignKey("Song_Title")]
        public Song Song { get; set; }
        [ForeignKey("MusicianId")]
        public Musician Musician { get; set; }
    }
}
