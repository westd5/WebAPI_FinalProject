using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioProjectController : ControllerBase
    {
        private readonly ILogger<PortfolioProjectController> _logger;
        private readonly IPortfolioProjectContextDAO _context;

        public PortfolioProjectController(ILogger<PortfolioProjectController> logger, IPortfolioProjectContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id == 0 || id == null)
            {
                var allPortfolioProjects = _context.GetAllProjects();
                var topFiveProjects = (from t in allPortfolioProjects select t).Take(5);
                return Ok(topFiveProjects);
            }

            var portfolioProject = _context.GetProjectById(id);
            if (portfolioProject == null) return NotFound(id);
            return Ok(portfolioProject);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveProjectById(id);
            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(PortfolioProject portfolioProject)
        {
            var result = _context.UpdateProject(portfolioProject);
            if (result == null) return NotFound(portfolioProject.Id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(PortfolioProject portfolioProject)
        {
            var result = _context.AddProject(portfolioProject);
            if (result == null) return StatusCode(500, "Album already exists");
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }
    }
}