using System.Collections.Generic;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Interfaces
{
    public interface ITalkingHeadsAlbumContextDAO
    {
        List<TalkingHeadsAlbum> GetAllAlbums();
        TalkingHeadsAlbum GetAlbumById(int id);
        int? RemoveAlbumById(int id);
        int? UpdateAlbum(TalkingHeadsAlbum talkingHeadsAlbum);
        int? AddAlbum(TalkingHeadsAlbum talkingHeadsAlbum);
    }
}