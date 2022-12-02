using Microsoft.EntityFrameworkCore;
using System;
using WebAPI_FinalProject.Models;

namespace WebAPI_FinalProject.Data
{
    public class WebAPI_FinalProjectContext : DbContext
    {
        public WebAPI_FinalProjectContext(DbContextOptions<WebAPI_FinalProjectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Daniel West", Birthdate = new DateTime(1987, 11, 7), CollegeProgram = "Information Technology - Software Development", YearInProgram = "Senior" },
                new TeamMember { Id = 2, FullName = "Jane Miller", Birthdate = new DateTime(2002, 10, 3), CollegeProgram = "Information Technology - Game Development", YearInProgram = "Junior" },
                new TeamMember { Id = 3, FullName = "John Lewis", Birthdate = new DateTime(2001, 5, 17), CollegeProgram = "Information Technology - Cyber Security", YearInProgram = "Senior" }
            );

            builder.Entity<TalkingHeadsAlbum>().HasData(
                new TalkingHeadsAlbum { Id = 1, AlbumName = "Talking Heads: '77", YearReleased = new DateTime(1977, 9, 16), NumberOfSongs = 11, RankedOrder = 4 },
                new TalkingHeadsAlbum { Id = 2, AlbumName = "More Songs About Buildings And Food", YearReleased = new DateTime(1978, 7, 14), NumberOfSongs = 11, RankedOrder = 5 },
                new TalkingHeadsAlbum { Id = 3, AlbumName = "Fear Of Music", YearReleased = new DateTime(1979, 8, 3), NumberOfSongs = 11, RankedOrder = 3 },
                new TalkingHeadsAlbum { Id = 4, AlbumName = "Remain In Light", YearReleased = new DateTime(1980, 10, 8), NumberOfSongs = 8, RankedOrder = 1 },
                new TalkingHeadsAlbum { Id = 5, AlbumName = "Speaking In Tongues", YearReleased = new DateTime(1983, 5, 31), NumberOfSongs = 9, RankedOrder = 2 },
                new TalkingHeadsAlbum { Id = 6, AlbumName = "Little Creatures", YearReleased = new DateTime(1985, 6, 10), NumberOfSongs = 9, RankedOrder = 6 },
                new TalkingHeadsAlbum { Id = 7, AlbumName = "True Stories", YearReleased = new DateTime(1986, 10, 7), NumberOfSongs = 11, RankedOrder = 7 },
                new TalkingHeadsAlbum { Id = 8, AlbumName = "Naked", YearReleased = new DateTime(1988, 3, 15), NumberOfSongs = 12, RankedOrder = 8 }
            );

            builder.Entity<PortfolioProject>().HasData(
                new PortfolioProject { Id = 1, ProjectName = "Poetry In Review", LanguagesUsed = "HTML/CSS/Javascript", YearCreated = new DateTime(2020), Description = "Reviews and criticism of newly released books of poetry" },
                new PortfolioProject { Id = 2, ProjectName = "Wrestling Timeline", LanguagesUsed = "HTML/CSS/Javascript/PHP", YearCreated = new DateTime(2022), Description = "Timeline of notable events in professional wrestling history" },
                new PortfolioProject { Id = 3, ProjectName = "Pesky Critter Application", LanguagesUsed = "Visual Basic", YearCreated = new DateTime(2016), Description = "Application to be used by business for rodent control" },
                new PortfolioProject { Id = 4, ProjectName = "Bowling Score Calculator", LanguagesUsed = "Visual Basic", YearCreated = new DateTime(2016), Description = "Application to calculate bowling scores" },
                new PortfolioProject { Id = 5, ProjectName = "Web API Example", LanguagesUsed = "C#", YearCreated = new DateTime(2022), Description = "This project!" }
            );

            builder.Entity<StarTrekVoyagerEpisode>().HasData(
                new StarTrekVoyagerEpisode { Id = 1, EpisodeName = "Night", OriginalAirdate = new DateTime(1998, 10, 14), RankedOrder = 6, Description = "Voyager loses power traversing a dark region of space containing theta radiation." },
                new StarTrekVoyagerEpisode { Id = 2, EpisodeName = "Drone", OriginalAirdate = new DateTime(1998, 10, 21), RankedOrder = 4, Description = "The Doctor's mobile emitter is damaged while beaming back from an away mission, merging with Seven of Nine's Borg nanoprobes and the DNA of a male Ensign to create a 29th century Borg." },
                new StarTrekVoyagerEpisode { Id = 3, EpisodeName = "Extreme Risk", OriginalAirdate = new DateTime(1998, 10, 28), RankedOrder = 1, Description = "B'Elanna purposely puts herself into increasingly dangerous situations. Meanwhile, the crew decides to build a new shuttlecraft, the Delta Flyer." },
                new StarTrekVoyagerEpisode { Id = 4, EpisodeName = "In The Flesh", OriginalAirdate = new DateTime(1998, 11, 4), RankedOrder = 7, Description = "The ship encounters a training facility for an alien invasion of Earth." },
                new StarTrekVoyagerEpisode { Id = 5, EpisodeName = "Once Upon A Time", OriginalAirdate = new DateTime(1998, 11, 11), RankedOrder = 5, Description = "Neelix looks after Naomi Wildman when her mother is injured on an away mission." },
                new StarTrekVoyagerEpisode { Id = 6, EpisodeName = "Timeless", OriginalAirdate = new DateTime(1998, 11, 18), RankedOrder = 2, Description = "Fifteen years in the future, Chakotay and Harry Kim attempt to prevent the Voyager from crash-landing on an ice planet." },
                new StarTrekVoyagerEpisode { Id = 7, EpisodeName = "Infinite Regress", OriginalAirdate = new DateTime(1998, 11, 25), RankedOrder = 3, Description = "When Voyager brings aboard an advanced piece of Borg technology from a salvaged Borg cube, Seven of Nine begins to take on the personalities of the people assimilated by the cube." },
                new StarTrekVoyagerEpisode { Id = 8, EpisodeName = "Nothing Human", OriginalAirdate = new DateTime(1998, 12, 2), RankedOrder = 9, Description = "A wounded alien is brought on board from a stranded vessel and attaches itself to B'Elanna Torres." },
                new StarTrekVoyagerEpisode { Id = 9, EpisodeName = "Thirty Days", OriginalAirdate = new DateTime(1998, 12, 9), RankedOrder = 10, Description = "Tom Paris disregards orders by helping an aquatic world and is demoted to Ensign." },
                new StarTrekVoyagerEpisode { Id = 10, EpisodeName = "Counterpoint", OriginalAirdate = new DateTime(1998, 12, 16), RankedOrder = 8, Description = "While passing through Devore space, Voyager is routinely searched for telepaths." }
            );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<TalkingHeadsAlbum> TalkingHeadsAlbums { get; set; }
        public DbSet<PortfolioProject> PortfolioProjects { get; set; }
        public DbSet<StarTrekVoyagerEpisode> StarTrekVoyagerEpisodes { get; set; }
    }
}