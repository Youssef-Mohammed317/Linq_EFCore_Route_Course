using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Song
    {
        [Key]
        public string Title { get; set; }
        public int Author_Id { get; set; }
        public int Album_Id { get; set; }

        // Navigation properties
        [ForeignKey("Author_Id")]
        public Author Author { get; set; }
        [ForeignKey("Album_Id")]
        public Album Album { get; set; }

        public ICollection<Song_Musican> Song_Musicans { get; set; }


    }
}
