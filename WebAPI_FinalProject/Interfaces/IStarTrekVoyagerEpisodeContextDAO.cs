using System.Collections.Generic;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Interfaces
{
    public interface IStarTrekVoyagerEpisodeContextDAO
    {
        List<StarTrekVoyagerEpisode> GetAllEpisodes();
        StarTrekVoyagerEpisode GetEpisodeById(int id);
        int? RemoveEpisodeById(int id);
        int? UpdateEpisode(StarTrekVoyagerEpisode starTrekVoyagerEpisode);
        int? AddEpisode(StarTrekVoyagerEpisode starTrekVoyagerEpisode);
    }
}