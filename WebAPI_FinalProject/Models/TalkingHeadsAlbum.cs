using System;

namespace WebAPI_FinalProject.Models
{
    public class TalkingHeadsAlbum
    {
        public long Id { get; set; }
        public string AlbumName { get; set; }
        public DateTime YearReleased { get; set; }
        public int NumberOfSongs { get; set; }
        public int RankedOrder { get; set; }
    }
}