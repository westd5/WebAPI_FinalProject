using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMemberController> _logger;
        private readonly ITeamMemberContextDAO _context;

        public TeamMemberController(ILogger<TeamMemberController> logger, ITeamMemberContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id == 0 || id == null)
            {
                var allTeamMembers = _context.GetAllTeamMembers();
                var topFiveTeamMembers = (from t in allTeamMembers select t).Take(5);
                return Ok(topFiveTeamMembers);
            }

            var teamMember = _context.GetTeamMemberById(id);
            if (teamMember == null) return NotFound(id);
            return Ok(teamMember);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveTeamMemberById(id);
            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TeamMember teamMember)
        {
            var result = _context.UpdateTeamMember(teamMember);
            if (result == null) return NotFound(teamMember.Id);
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(TeamMember teamMember)
        {
            var result = _context.AddTeamMember(teamMember);
            if (result == null) return StatusCode(500, "Team already exists");
            if (result == 0) return StatusCode(500, "An error occurred while processing your request");
            return Ok();
        }
    }
}