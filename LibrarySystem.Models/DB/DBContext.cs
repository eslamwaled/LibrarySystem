using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models.Entities
;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class DBContext : IdentityDbContext<User>
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
    }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var admin = new IdentityRole("admin");
        admin.NormalizedName = "admin";

        var user = new IdentityRole("user");
        user.NormalizedName = "user";

        modelBuilder.Entity<IdentityRole>().HasData(user, admin);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
