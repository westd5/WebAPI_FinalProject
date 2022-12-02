using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarTrekVoyagerEpisodeController : ControllerBase
    {
        private readonly ILogger<StarTrekVoyagerEpisodeController> _logger;
        private readonly IStarTrekVoyagerEpisodeContextDAO _context;

        public StarTrekVoyagerEpisodeController(ILogger<StarTrekVoyagerEpisodeController> logger, IStarTrekVoyagerEpisodeContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id == 0 || id == null)
            {
                var allStarTrekVoyagerEpisodes = _context.GetAllEpisodes();
                var topFiveEpisodes = (from t in allStarTrekVoyagerEpisodes select t).Take(5);
                return Ok(topFiveEpisodes);
            }

            var starTrekVoyagerEpisode = _context.GetEpisodeById(id);
            if (starTrekVoyagerEpisode == null) return NotFound(id);
            return Ok(starTrekVoyagerEpisode);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveEpisodeById(id);
            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(StarTrekVoyagerEpisode starTrekVoyagerEpisode)
        {
            var result = _context.UpdateEpisode(starTrekVoyagerEpisode);
            if (result == null) return NotFound(starTrekVoyagerEpisode.Id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(StarTrekVoyagerEpisode starTrekVoyagerEpisode)
        {
            var result = _context.AddEpisode(starTrekVoyagerEpisode);
            if (result == null) return StatusCode(500, "Album already exists");
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }
    }
}