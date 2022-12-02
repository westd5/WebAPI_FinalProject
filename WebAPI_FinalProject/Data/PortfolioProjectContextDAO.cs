using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_FinalProject.Interfaces;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Data
{
    public class PortfolioProjectContextDAO : IPortfolioProjectContextDAO
    {
        private WebAPI_FinalProjectContext _context;
        public PortfolioProjectContextDAO(WebAPI_FinalProjectContext context)
        {
            _context = context;
        }

        public List<PortfolioProject> GetAllProjects()
        {
            return _context.PortfolioProjects.ToList();
        }

        public PortfolioProject GetProjectById(int id)
        {
            return _context.PortfolioProjects.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveProjectById(int id)
        {
            var portfolioProject = this.GetProjectById(id);

            if (portfolioProject == null) return null;

            try
            {
                _context.PortfolioProjects.Remove(portfolioProject);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateProject(PortfolioProject portfolioProject)
        {
            var portfolioProjectToUpdate = this.GetProjectById(Convert.ToInt32(portfolioProject.Id));

            if (portfolioProjectToUpdate == null) return null;

            portfolioProjectToUpdate.ProjectName = portfolioProject.ProjectName;
            portfolioProjectToUpdate.LanguagesUsed = portfolioProject.LanguagesUsed;
            portfolioProjectToUpdate.YearCreated = portfolioProject.YearCreated;
            portfolioProjectToUpdate.Description = portfolioProject.Description;

            try
            {
                _context.PortfolioProjects.Update(portfolioProjectToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? AddProject(PortfolioProject portfolioProject)
        {
            var newPortfolioProjectExists = _context.PortfolioProjects.Where(x => x.ProjectName.Equals(portfolioProject.ProjectName) && x.YearCreated.Equals(portfolioProject.YearCreated)).FirstOrDefault();

            if (newPortfolioProjectExists != null) return null;

            try
            {
                _context.PortfolioProjects.Add(portfolioProject);
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