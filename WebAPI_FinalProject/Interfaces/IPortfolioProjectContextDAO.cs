using System.Collections.Generic;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Interfaces
{
    public interface IPortfolioProjectContextDAO
    {
        List<PortfolioProject> GetAllProjects();
        PortfolioProject GetProjectById(int id);
        int? RemoveProjectById(int id);
        int? UpdateProject(PortfolioProject portfolioProject);
        int? AddProject(PortfolioProject portfolioProject);
    }
}