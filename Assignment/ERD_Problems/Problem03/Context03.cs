using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ERD_Problems.Problem03
{
    internal class Context03 : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Musican_Instrument> Musican_Instruments { get; set; }
        public DbSet<Song_Musican> Song_Musicans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ERD_Problem03;Trusted_Connection=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musican_Instrument>()
                .HasKey(mi => new { mi.MusicianId, mi.Instrument_Name });
            modelBuilder.Entity<Song_Musican>()
                .HasKey(sm => new { sm.Song_Title, sm.MusicianId });
        }

    }

}
