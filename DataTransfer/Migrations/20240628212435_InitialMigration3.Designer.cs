﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataTransfer.Migrations
{
    [DbContext(typeof(OlympicContext))]
    [Migration("20240628212435_InitialMigration3")]
    partial class InitialMigration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "1",
                            CategoryID = "indoor",
                            FlagImage = "Canada.png",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "2",
                            CategoryID = "indoor",
                            FlagImage = "Sweden.png",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "3",
                            CategoryID = "indoor",
                            FlagImage = "UK.png",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "4",
                            CategoryID = "outdoor",
                            FlagImage = "Jamaica.png",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "5",
                            CategoryID = "outdoor",
                            FlagImage = "Italy.png",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "6",
                            CategoryID = "outdoor",
                            FlagImage = "Japan.png",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "7",
                            CategoryID = "indoor",
                            FlagImage = "Germany.png",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "8",
                            CategoryID = "indoor",
                            FlagImage = "China.png",
                            Name = "China"
                        },
                        new
                        {
                            CountryID = "9",
                            CategoryID = "indoor",
                            FlagImage = "Mexico.png",
                            Name = "Mexico"
                        },
                        new
                        {
                            CountryID = "10",
                            CategoryID = "outdoor",
                            FlagImage = "Brazil.png",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "11",
                            CategoryID = "outdoor",
                            FlagImage = "Netherlands.png",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "12",
                            CategoryID = "outdoor",
                            FlagImage = "US.png",
                            Name = "USA"
                        },
                        new
                        {
                            CountryID = "13",
                            CategoryID = "indoor",
                            FlagImage = "Thailand.png",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "14",
                            CategoryID = "indoor",
                            FlagImage = "Uruguay.png",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "15",
                            CategoryID = "indoor",
                            FlagImage = "Ukraine.png",
                            Name = "Ukraine"
                        },
                        new
                        {
                            CountryID = "16",
                            CategoryID = "outdoor",
                            FlagImage = "Austria.png",
                            Name = "Austria"
                        },
                        new
                        {
                            CountryID = "17",
                            CategoryID = "outdoor",
                            FlagImage = "Pakistan.png",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "18",
                            CategoryID = "outdoor",
                            FlagImage = "Zimbabwe.png",
                            Name = "Zimbabwe"
                        },
                        new
                        {
                            CountryID = "19",
                            CategoryID = "indoor",
                            FlagImage = "France.png",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "20",
                            CategoryID = "indoor",
                            FlagImage = "Cyprus.png",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "21",
                            CategoryID = "indoor",
                            FlagImage = "Russia.png",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "22",
                            CategoryID = "outdoor",
                            FlagImage = "Finland.png",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "23",
                            CategoryID = "outdoor",
                            FlagImage = "Slovakia.png",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "24",
                            CategoryID = "outdoor",
                            FlagImage = "Portugal.png",
                            Name = "Portugal"
                        });
                });

            modelBuilder.Entity("Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "paralympics",
                            Name = "Paralympic Games"
                        },
                        new
                        {
                            GameID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.Navigation("Category");

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
