﻿using System;

namespace WebAPI_FinalProject.Models
{
    public class TeamMember
    {
        public long Id { get; set; }
        public string FullName { get; set; }

        public DateTime Birthdate { get; set; }

        public string CollegeProgram { get; set; }

        public string YearInProgram { get; set; }
    }
}