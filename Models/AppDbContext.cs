using Microsoft.EntityFrameworkCore;

namespace lab3.Models;

public class AppDbContext : DbContext
{
    public DbSet<ContactEntity> Contacts { get; set; }

    private string DbPath { get; set; }
    
    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;

        var path = Environment.GetFolderPath(folder);

        DbPath = Path.Join(path, "contacts.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ContactEntity>()
            .HasData(
                new ContactEntity()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@gmail.com",
                    PhoneNumber = "123123123",
                    BirthDate = new DateTime(2000, 10, 10),
                    Category = Category.Business,
                    // CreatedAt = DateTime.Now
                },
                new ContactEntity()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "janedoe@gmail.com",
                    PhoneNumber = "321231321",
                    BirthDate = new DateTime(2002, 1, 23),
                    Category = Category.Family,
                    // CreatedAt = DateTime.Now
                }
            );
}

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite($"Data source={DbPath}");
    // }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlite($"Data source={DbPath}");

    // Drop the database and recreate it for a clean slate
    // this.Database.EnsureDeleted();
    // this.Database.EnsureCreated();
}

}