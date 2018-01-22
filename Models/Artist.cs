using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicHistory.Models
{
  public class Artist
  {
    [Key]
    public int ArtistId { get; set; }

    [Required]
    [StringLength(55)]
    [Display(Name="Name")]
    public string ArtistName { get; set; }

    [Required]
    [Display(Name="Founded")]
    public int YearEstablished { get; set; }

    public ICollection<Song> Songs;
  }
}