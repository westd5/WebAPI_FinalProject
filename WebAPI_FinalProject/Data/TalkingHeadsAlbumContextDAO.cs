using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Data
{
    public class TalkingHeadsAlbumContextDAO : ITalkingHeadsAlbumContextDAO
    {
        private WebAPI_FinalProjectContext _context;
        public TalkingHeadsAlbumContextDAO(WebAPI_FinalProjectContext context)
        {
            _context = context;
        }

        public List<TalkingHeadsAlbum> GetAllAlbums()
        {
            return _context.TalkingHeadsAlbums.ToList();
        }

        public TalkingHeadsAlbum GetAlbumById(int id)
        {
            return _context.TalkingHeadsAlbums.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveAlbumById(int id)
        {
            var talkingHeadsAlbum = this.GetAlbumById(id);

            if (talkingHeadsAlbum == null) return null;

            try
            {
                _context.TalkingHeadsAlbums.Remove(talkingHeadsAlbum);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateAlbum(TalkingHeadsAlbum talkingHeadsAlbum)
        {
            var talkingHeadsAlbumToUpdate = this.GetAlbumById(Convert.ToInt32(talkingHeadsAlbum.Id));

            if (talkingHeadsAlbumToUpdate == null) return null;

            talkingHeadsAlbumToUpdate.AlbumName = talkingHeadsAlbum.AlbumName;
            talkingHeadsAlbumToUpdate.YearReleased = talkingHeadsAlbum.YearReleased;
            talkingHeadsAlbumToUpdate.NumberOfSongs = talkingHeadsAlbum.NumberOfSongs;
            talkingHeadsAlbumToUpdate.RankedOrder = talkingHeadsAlbum.RankedOrder;

            try
            {
                _context.TalkingHeadsAlbums.Update(talkingHeadsAlbumToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? AddAlbum(TalkingHeadsAlbum talkingHeadsAlbum)
        {
            var newTalkingHeadsAlbumExists = _context.TalkingHeadsAlbums.Where(x => x.AlbumName.Equals(talkingHeadsAlbum.AlbumName) && x.YearReleased.Equals(talkingHeadsAlbum.YearReleased)).FirstOrDefault();

            if (newTalkingHeadsAlbumExists != null) return null;

            try
            {
                _context.TalkingHeadsAlbums.Add(talkingHeadsAlbum);
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