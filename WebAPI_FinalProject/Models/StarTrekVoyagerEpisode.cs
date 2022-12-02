using System;

namespace WebAPI_FinalProject.Models
{
    public class StarTrekVoyagerEpisode
    {
        public long Id { get; set; }
        public string EpisodeName { get; set; }
        public DateTime OriginalAirdate { get; set; }
        public int RankedOrder { get; set; }
        public string Description { get; set; }
    }
}