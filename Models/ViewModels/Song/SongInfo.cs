using System;

namespace MusicHistory.Models.ViewModels
{
    public class SongInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public int Length { get; set; }
        public string Artist { get; set; }
    }
}