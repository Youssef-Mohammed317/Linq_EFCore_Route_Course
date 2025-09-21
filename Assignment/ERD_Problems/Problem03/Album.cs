using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int Musician_Id { get; set; }
        public DateTime Date { get; set; }

        // Navigation property
        [ForeignKey("Musician_Id")]
        public Musician Musician { get; set; }

        public ICollection<Song> Songs { get; set; }

    }
}
