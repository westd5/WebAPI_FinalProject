using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortfolioProjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    LanguagesUsed = table.Column<string>(nullable: true),
                    YearCreated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StarTrekVoyagerEpisodes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpisodeName = table.Column<string>(nullable: true),
                    OriginalAirdate = table.Column<DateTime>(nullable: false),
                    RankedOrder = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarTrekVoyagerEpisodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalkingHeadsAlbums",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(nullable: true),
                    YearReleased = table.Column<DateTime>(nullable: false),
                    NumberOfSongs = table.Column<int>(nullable: false),
                    RankedOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalkingHeadsAlbums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    CollegeProgram = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PortfolioProjects",
                columns: new[] { "Id", "Description", "LanguagesUsed", "ProjectName", "YearCreated" },
                values: new object[,]
                {
                    { 1L, "Reviews and criticism of newly released books of poetry", "HTML/CSS/Javascript", "Poetry In Review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020) },
                    { 2L, "Timeline of notable events in professional wrestling history", "HTML/CSS/Javascript/PHP", "Wrestling Timeline", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022) },
                    { 3L, "Application to be used by business for rodent control", "Visual Basic", "Pesky Critter Application", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016) },
                    { 4L, "Application to calculate bowling scores", "Visual Basic", "Bowling Score Calculator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016) },
                    { 5L, "This project!", "C#", "Web API Example", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022) }
                });

            migrationBuilder.InsertData(
                table: "StarTrekVoyagerEpisodes",
                columns: new[] { "Id", "Description", "EpisodeName", "OriginalAirdate", "RankedOrder" },
                values: new object[,]
                {
                    { 10L, "While passing through Devore space, Voyager is routinely searched for telepaths.", "Counterpoint", new DateTime(1998, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9L, "Tom Paris disregards orders by helping an aquatic world and is demoted to Ensign.", "Thirty Days", new DateTime(1998, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 7L, "When Voyager brings aboard an advanced piece of Borg technology from a salvaged Borg cube, Seven of Nine begins to take on the personalities of the people assimilated by the cube.", "Infinite Regress", new DateTime(1998, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6L, "Fifteen years in the future, Chakotay and Harry Kim attempt to prevent the Voyager from crash-landing on an ice planet.", "Timeless", new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8L, "A wounded alien is brought on board from a stranded vessel and attaches itself to B'Elanna Torres.", "Nothing Human", new DateTime(1998, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 4L, "The ship encounters a training facility for an alien invasion of Earth.", "In The Flesh", new DateTime(1998, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 3L, "B'Elanna purposely puts herself into increasingly dangerous situations. Meanwhile, the crew decides to build a new shuttlecraft, the Delta Flyer.", "Extreme Risk", new DateTime(1998, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2L, "The Doctor's mobile emitter is damaged while beaming back from an away mission, merging with Seven of Nine's Borg nanoprobes and the DNA of a male Ensign to create a 29th century Borg.", "Drone", new DateTime(1998, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 1L, "Voyager loses power traversing a dark region of space containing theta radiation.", "Night", new DateTime(1998, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 5L, "Neelix looks after Naomi Wildman when her mother is injured on an away mission.", "Once Upon A Time", new DateTime(1998, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "TalkingHeadsAlbums",
                columns: new[] { "Id", "AlbumName", "NumberOfSongs", "RankedOrder", "YearReleased" },
                values: new object[,]
                {
                    { 1L, "Talking Heads: '77", 11, 4, new DateTime(1977, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "More Songs About Buildings And Food", 11, 5, new DateTime(1978, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "Fear Of Music", 11, 3, new DateTime(1979, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "Remain In Light", 8, 1, new DateTime(1980, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "Speaking In Tongues", 9, 2, new DateTime(1983, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, "Little Creatures", 9, 6, new DateTime(1985, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "True Stories", 11, 7, new DateTime(1986, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "Naked", 12, 8, new DateTime(1988, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 2L, new DateTime(2002, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology - Game Development", "Jane Miller", "Junior" },
                    { 1L, new DateTime(1987, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology - Software Development", "Daniel West", "Senior" },
                    { 3L, new DateTime(2001, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology - Cyber Security", "John Lewis", "Senior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioProjects");

            migrationBuilder.DropTable(
                name: "StarTrekVoyagerEpisodes");

            migrationBuilder.DropTable(
                name: "TalkingHeadsAlbums");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
