using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
{
    public DBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DBContext>();

        optionsBuilder.UseSqlServer("Data Source=DESKTOP-CPU392U\\SQLEXPRESS;Initial Catalog=LibrarySystem;TrustServerCertificate=True;Integrated Security=True");

        return new DBContext(optionsBuilder.Options);
    }
}
