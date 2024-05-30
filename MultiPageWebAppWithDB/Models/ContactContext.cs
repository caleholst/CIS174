using Microsoft.EntityFrameworkCore;

namespace MultiPageWebAppWithDB.Models;

public class ContactContext : DbContext
{
    public ContactContext(DbContextOptions<ContactContext> options): base(options)
    { }

    public DbSet<Contact> Contacts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Name = "Cale",
                PhoneNumber = "515-240-6671",
                Address = "123 Main St.",
                Note = "this is me"
            },
             new Contact
             {
                 ContactId = 2,
                 Name = "Bob",
                 PhoneNumber = "555-555-5555",
                 Address = "123 1st Ave.",
                 Note = "This is Bob"
             },
              new Contact
              {
                  ContactId = 3,
                  Name = "Joe Smith",
                  PhoneNumber = "999-999-9999",
                  Address = "987 3rd St.",
                  Note = "This is Joe Smith"
              }
            );
    }
}
