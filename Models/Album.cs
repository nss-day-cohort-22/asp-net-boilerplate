using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicHistory.Models
{
  public class Album
  {
    [Key]
    public int AlbumId { get; set; }

    [Required]
    [StringLength(55)]
    public string Title { get; set; }
    public ICollection<Song> Songs;
  }
}