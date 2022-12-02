using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TalkingHeadsAlbumController : ControllerBase
    {
        private readonly ILogger<TalkingHeadsAlbumController> _logger;
        private readonly ITalkingHeadsAlbumContextDAO _context;

        public TalkingHeadsAlbumController(ILogger<TalkingHeadsAlbumController> logger, ITalkingHeadsAlbumContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id == 0 || id == null)
            {
                var allTalkingHeadsAlbums = _context.GetAllAlbums();
                var topFiveAlbums = (from t in allTalkingHeadsAlbums select t).Take(5);
                return Ok(topFiveAlbums);
            }

            var talkingHeadsAlbum = _context.GetAlbumById(id);
            if (talkingHeadsAlbum == null) return NotFound(id);
            return Ok(talkingHeadsAlbum);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveAlbumById(id);
            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TalkingHeadsAlbum talkingHeadsAlbum)
        {
            var result = _context.UpdateAlbum(talkingHeadsAlbum);
            if (result == null) return NotFound(talkingHeadsAlbum.Id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(TalkingHeadsAlbum talkingHeadsAlbum)
        {
            var result = _context.AddAlbum(talkingHeadsAlbum);
            if (result == null) return StatusCode(500, "Album already exists");
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }
    }
}