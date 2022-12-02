﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_FinalProject.Data;

namespace WebAPI_FinalProject.Migrations
{
    [DbContext(typeof(WebAPI_FinalProjectContext))]
    [Migration("20221202234353_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI_FinalProject.Models.PortfolioProject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguagesUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PortfolioProjects");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Reviews and criticism of newly released books of poetry",
                            LanguagesUsed = "HTML/CSS/Javascript",
                            ProjectName = "Poetry In Review",
                            YearCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020)
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Timeline of notable events in professional wrestling history",
                            LanguagesUsed = "HTML/CSS/Javascript/PHP",
                            ProjectName = "Wrestling Timeline",
                            YearCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022)
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Application to be used by business for rodent control",
                            LanguagesUsed = "Visual Basic",
                            ProjectName = "Pesky Critter Application",
                            YearCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016)
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Application to calculate bowling scores",
                            LanguagesUsed = "Visual Basic",
                            ProjectName = "Bowling Score Calculator",
                            YearCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016)
                        },
                        new
                        {
                            Id = 5L,
                            Description = "This project!",
                            LanguagesUsed = "C#",
                            ProjectName = "Web API Example",
                            YearCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022)
                        });
                });

            modelBuilder.Entity("WebAPI_FinalProject.Models.StarTrekVoyagerEpisode", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EpisodeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OriginalAirdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RankedOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StarTrekVoyagerEpisodes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Voyager loses power traversing a dark region of space containing theta radiation.",
                            EpisodeName = "Night",
                            OriginalAirdate = new DateTime(1998, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 6
                        },
                        new
                        {
                            Id = 2L,
                            Description = "The Doctor's mobile emitter is damaged while beaming back from an away mission, merging with Seven of Nine's Borg nanoprobes and the DNA of a male Ensign to create a 29th century Borg.",
                            EpisodeName = "Drone",
                            OriginalAirdate = new DateTime(1998, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 4
                        },
                        new
                        {
                            Id = 3L,
                            Description = "B'Elanna purposely puts herself into increasingly dangerous situations. Meanwhile, the crew decides to build a new shuttlecraft, the Delta Flyer.",
                            EpisodeName = "Extreme Risk",
                            OriginalAirdate = new DateTime(1998, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 1
                        },
                        new
                        {
                            Id = 4L,
                            Description = "The ship encounters a training facility for an alien invasion of Earth.",
                            EpisodeName = "In The Flesh",
                            OriginalAirdate = new DateTime(1998, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 7
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Neelix looks after Naomi Wildman when her mother is injured on an away mission.",
                            EpisodeName = "Once Upon A Time",
                            OriginalAirdate = new DateTime(1998, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 5
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Fifteen years in the future, Chakotay and Harry Kim attempt to prevent the Voyager from crash-landing on an ice planet.",
                            EpisodeName = "Timeless",
                            OriginalAirdate = new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 2
                        },
                        new
                        {
                            Id = 7L,
                            Description = "When Voyager brings aboard an advanced piece of Borg technology from a salvaged Borg cube, Seven of Nine begins to take on the personalities of the people assimilated by the cube.",
                            EpisodeName = "Infinite Regress",
                            OriginalAirdate = new DateTime(1998, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 3
                        },
                        new
                        {
                            Id = 8L,
                            Description = "A wounded alien is brought on board from a stranded vessel and attaches itself to B'Elanna Torres.",
                            EpisodeName = "Nothing Human",
                            OriginalAirdate = new DateTime(1998, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 9
                        },
                        new
                        {
                            Id = 9L,
                            Description = "Tom Paris disregards orders by helping an aquatic world and is demoted to Ensign.",
                            EpisodeName = "Thirty Days",
                            OriginalAirdate = new DateTime(1998, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 10
                        },
                        new
                        {
                            Id = 10L,
                            Description = "While passing through Devore space, Voyager is routinely searched for telepaths.",
                            EpisodeName = "Counterpoint",
                            OriginalAirdate = new DateTime(1998, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RankedOrder = 8
                        });
                });

            modelBuilder.Entity("WebAPI_FinalProject.Models.TalkingHeadsAlbum", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSongs")
                        .HasColumnType("int");

                    b.Property<int>("RankedOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("YearReleased")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TalkingHeadsAlbums");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AlbumName = "Talking Heads: '77",
                            NumberOfSongs = 11,
                            RankedOrder = 4,
                            YearReleased = new DateTime(1977, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            AlbumName = "More Songs About Buildings And Food",
                            NumberOfSongs = 11,
                            RankedOrder = 5,
                            YearReleased = new DateTime(1978, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            AlbumName = "Fear Of Music",
                            NumberOfSongs = 11,
                            RankedOrder = 3,
                            YearReleased = new DateTime(1979, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            AlbumName = "Remain In Light",
                            NumberOfSongs = 8,
                            RankedOrder = 1,
                            YearReleased = new DateTime(1980, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5L,
                            AlbumName = "Speaking In Tongues",
                            NumberOfSongs = 9,
                            RankedOrder = 2,
                            YearReleased = new DateTime(1983, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6L,
                            AlbumName = "Little Creatures",
                            NumberOfSongs = 9,
                            RankedOrder = 6,
                            YearReleased = new DateTime(1985, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7L,
                            AlbumName = "True Stories",
                            NumberOfSongs = 11,
                            RankedOrder = 7,
                            YearReleased = new DateTime(1986, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8L,
                            AlbumName = "Naked",
                            NumberOfSongs = 12,
                            RankedOrder = 8,
                            YearReleased = new DateTime(1988, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebAPI_FinalProject.Models.TeamMember", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Birthdate = new DateTime(1987, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology - Software Development",
                            FullName = "Daniel West",
                            YearInProgram = "Senior"
                        },
                        new
                        {
                            Id = 2L,
                            Birthdate = new DateTime(2002, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology - Game Development",
                            FullName = "Jane Miller",
                            YearInProgram = "Junior"
                        },
                        new
                        {
                            Id = 3L,
                            Birthdate = new DateTime(2001, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology - Cyber Security",
                            FullName = "John Lewis",
                            YearInProgram = "Senior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
