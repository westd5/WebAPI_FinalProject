using System;

namespace WebAPI_FinalProject.Models
{
    public class PortfolioProject
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string LanguagesUsed { get; set; }
        public DateTime YearCreated { get; set; }
        public string Description { get; set; }
    }
}