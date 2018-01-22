using System;
using System.ComponentModel.DataAnnotations;

namespace MusicHistory.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [Required]
        [StringLength(55)]
        public string Title { get; set; }

        [Required]
        [StringLength(55)]
        public int SongLength { get; set; }

        [Required]
        [StringLength(55)]
        public DateTime ReleaseDate { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}