using System.Collections.Generic;
using System.Reflection.Emit;
using DataTransfer.Models;
using Microsoft.EntityFrameworkCore;

public class OlympicContext : DbContext
{
    public OlympicContext(DbContextOptions<OlympicContext> options) : base(options) { }

    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<Game> Games { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    public DbSet<Ticket> Tickets { get; set; } = null!;
    public DbSet<Status> Statuses { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Game>().HasData(
            new Game { GameID = "summer", Name = "Summer Olympics" },
            new Game { GameID = "winter", Name = "Winter Olympics" },
            new Game { GameID = "paralympics", Name = "Paralympic Games" },
            new Game { GameID = "youth", Name = "Youth Olympic Games" }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = "indoor", Name = "Indoor" },
            new Category { CategoryID = "outdoor", Name = "Outdoor" }
        );

        modelBuilder.Entity<Country>().HasData(
        new Country { CountryID = "1", Name = "Canada", FlagImage = "Canada.png", CategoryID = "indoor", GameID = "winter" },
        new Country { CountryID = "2", Name = "Sweden", FlagImage = "Sweden.png", CategoryID = "indoor", GameID = "winter" },
        new Country { CountryID = "3", Name = "Great Britain", FlagImage = "UK.png", CategoryID = "indoor", GameID = "winter" },
        new Country { CountryID = "4", Name = "Jamaica", FlagImage = "Jamaica.png", CategoryID = "outdoor", GameID = "winter" },
        new Country { CountryID = "5", Name = "Italy", FlagImage = "Italy.png", CategoryID = "outdoor", GameID = "winter" },
        new Country { CountryID = "6", Name = "Japan", FlagImage = "Japan.png", CategoryID = "outdoor", GameID = "winter" },
        new Country { CountryID = "7", Name = "Germany", FlagImage = "Germany.png", CategoryID = "indoor", GameID = "summer" },
        new Country { CountryID = "8", Name = "China", FlagImage = "China.png", CategoryID = "indoor", GameID = "summer" },
        new Country { CountryID = "9", Name = "Mexico", FlagImage = "Mexico.png", CategoryID = "indoor", GameID = "summer" },
        new Country { CountryID = "10", Name = "Brazil", FlagImage = "Brazil.png", CategoryID = "outdoor", GameID = "summer" },
        new Country { CountryID = "11", Name = "Netherlands", FlagImage = "Netherlands.png", CategoryID = "outdoor", GameID = "summer" },
        new Country { CountryID = "12", Name = "USA", FlagImage = "US.png", CategoryID = "outdoor", GameID = "summer" },
        new Country { CountryID = "13", Name = "Thailand", FlagImage = "Thailand.png", CategoryID = "indoor", GameID = "paralympics" },
        new Country { CountryID = "14", Name = "Uruguay", FlagImage = "Uruguay.png", CategoryID = "indoor", GameID = "paralympics" },
        new Country { CountryID = "15", Name = "Ukraine", FlagImage = "Ukraine.png", CategoryID = "indoor", GameID = "paralympics" },
        new Country { CountryID = "16", Name = "Austria", FlagImage = "Austria.png", CategoryID = "outdoor", GameID = "paralympics" },
        new Country { CountryID = "17", Name = "Pakistan", FlagImage = "Pakistan.png", CategoryID = "outdoor", GameID = "paralympics" },
        new Country { CountryID = "18", Name = "Zimbabwe", FlagImage = "Zimbabwe.png", CategoryID = "outdoor", GameID = "paralympics" },
        new Country { CountryID = "19", Name = "France", FlagImage = "France.png", CategoryID = "indoor", GameID = "youth" },
        new Country { CountryID = "20", Name = "Cyprus", FlagImage = "Cyprus.png", CategoryID = "indoor", GameID = "youth" },
        new Country { CountryID = "21", Name = "Russia", FlagImage = "Russia.png", CategoryID = "indoor", GameID = "youth" },
        new Country { CountryID = "22", Name = "Finland", FlagImage = "Finland.png", CategoryID = "outdoor", GameID = "youth" },
        new Country { CountryID = "23", Name = "Slovakia", FlagImage = "Slovakia.png", CategoryID = "outdoor", GameID = "youth" },
        new Country { CountryID = "24", Name = "Portugal", FlagImage = "Portugal.png", CategoryID = "outdoor", GameID = "youth" }

        );
    }
}