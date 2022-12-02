using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Data
{
    public class StarTrekVoyagerEpisodeContextDAO : IStarTrekVoyagerEpisodeContextDAO
    {
        private WebAPI_FinalProjectContext _context;
        public StarTrekVoyagerEpisodeContextDAO(WebAPI_FinalProjectContext context)
        {
            _context = context;
        }

        public List<StarTrekVoyagerEpisode> GetAllEpisodes()
        {
            return _context.StarTrekVoyagerEpisodes.ToList();
        }

        public StarTrekVoyagerEpisode GetEpisodeById(int id)
        {
            return _context.StarTrekVoyagerEpisodes.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveEpisodeById(int id)
        {
            var starTrekVoyagerEpisode = this.GetEpisodeById(id);

            if (starTrekVoyagerEpisode == null) return null;

            try
            {
                _context.StarTrekVoyagerEpisodes.Remove(starTrekVoyagerEpisode);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateEpisode(StarTrekVoyagerEpisode starTrekVoyagerEpisode)
        {
            var starTrekVoyagerEpisodeToUpdate = this.GetEpisodeById(Convert.ToInt32(starTrekVoyagerEpisode.Id));

            if (starTrekVoyagerEpisodeToUpdate == null) return null;

            starTrekVoyagerEpisodeToUpdate.EpisodeName = starTrekVoyagerEpisode.EpisodeName;
            starTrekVoyagerEpisodeToUpdate.OriginalAirdate = starTrekVoyagerEpisode.OriginalAirdate;
            starTrekVoyagerEpisodeToUpdate.RankedOrder = starTrekVoyagerEpisode.RankedOrder;
            starTrekVoyagerEpisodeToUpdate.Description = starTrekVoyagerEpisode.Description;

            try
            {
                _context.StarTrekVoyagerEpisodes.Update(starTrekVoyagerEpisodeToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? AddEpisode(StarTrekVoyagerEpisode starTrekVoyagerEpisode)
        {
            var newStarTrekVoyagerEpisodeExists = _context.StarTrekVoyagerEpisodes.Where(x => x.EpisodeName.Equals(starTrekVoyagerEpisode.EpisodeName) && x.OriginalAirdate.Equals(starTrekVoyagerEpisode.OriginalAirdate)).FirstOrDefault();

            if (newStarTrekVoyagerEpisodeExists != null) return null;

            try
            {
                _context.StarTrekVoyagerEpisodes.Add(starTrekVoyagerEpisode);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}