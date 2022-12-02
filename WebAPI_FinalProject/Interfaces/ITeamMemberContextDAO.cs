using System.Collections.Generic;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        List<TeamMember> GetAllTeamMembers();
        TeamMember GetTeamMemberById(int id);
        int? RemoveTeamMemberById(int id);
        int? UpdateTeamMember(TeamMember teamMember);
        int? AddTeamMember(TeamMember teamMember);
    }
}