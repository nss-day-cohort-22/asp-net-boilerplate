using Microsoft.EntityFrameworkCore;
using MusicHistory.Models;

namespace MusicHistory.Data
{
    public class MusicHistoryContext : DbContext
    {
        public MusicHistoryContext(DbContextOptions<MusicHistoryContext> options)
            : base(options)
        { }

        public DbSet<Song> Song { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

}