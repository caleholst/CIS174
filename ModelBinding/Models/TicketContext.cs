using Microsoft.EntityFrameworkCore;
using ModelBinding.Models;

public class TicketContext : DbContext
{
    public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Status> Statuses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = "work", Name = "Work" },
            new Category { CategoryId = "home", Name = "Home" },
            new Category { CategoryId = "ex", Name = "Exercise" },
            new Category { CategoryId = "shop", Name = "Shopping" },
            new Category { CategoryId = "call", Name = "Contact" }
        );

        modelBuilder.Entity<Status>().HasData(
            new Status { StatusId = "open", Name = "Open" },
            new Status { StatusId = "closed", Name = "Completed" }
        );
    }
}