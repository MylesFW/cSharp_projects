using Microsoft.EntityFrameworkCore;

namespace crudelicious.Models
{
    public class MyContext : DbContext
    {
    public MyContext(DbContextOptions options) : base(options) { }
    // the "Monsters" table name will come from the DbSet variable name
    public DbSet<Monster> Monsters { get; set; }
    }
}