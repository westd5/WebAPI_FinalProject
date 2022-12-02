using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Data
{
    public class TeamMemberContextDAO : ITeamMemberContextDAO
    {
        private WebAPI_FinalProjectContext _context;
        public TeamMemberContextDAO(WebAPI_FinalProjectContext context)
        {
            _context = context;
        }
        public List<TeamMember> GetAllTeamMembers()
        {
            return _context.TeamMembers.ToList();
        }
        public TeamMember GetTeamMemberById(int id)
        {
            return _context.TeamMembers.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public int? RemoveTeamMemberById(int id)
        {
            var teamMember = this.GetTeamMemberById(id);

            if (teamMember == null) return null;

            try
            {
                _context.TeamMembers.Remove(teamMember);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int? UpdateTeamMember(TeamMember teamMember)
        {
            var teamMemberToUpdate = this.GetTeamMemberById(Convert.ToInt32(teamMember.Id));

            if (teamMemberToUpdate == null) return null;

            teamMemberToUpdate.FullName = teamMember.FullName;
            teamMemberToUpdate.Birthdate = teamMember.Birthdate;
            teamMemberToUpdate.CollegeProgram = teamMember.CollegeProgram;
            teamMemberToUpdate.YearInProgram = teamMember.YearInProgram;

            try
            {
                _context.TeamMembers.Update(teamMemberToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int? AddTeamMember(TeamMember teamMember)
        {
            var newTeamMemberExists = _context.TeamMembers.Where(x => x.FullName.Equals(teamMember.FullName) && x.Birthdate.Equals(teamMember.Birthdate)).FirstOrDefault();

            if (newTeamMemberExists != null) return null;

            try
            {
                _context.TeamMembers.Add(teamMember);
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