using Microsoft.EntityFrameworkCore;

namespace crud_elicious.Models
{
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dish { get; set; }
    }
}