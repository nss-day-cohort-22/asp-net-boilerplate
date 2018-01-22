using System.Collections.Generic;
using MusicHistory.Models;
using MusicHistory.Data;

namespace MusicHistory.Models.ViewModels
{
  public class SongListViewModel
  {
    public IEnumerable<SongInfo> Songs { get; set; }
  }
}