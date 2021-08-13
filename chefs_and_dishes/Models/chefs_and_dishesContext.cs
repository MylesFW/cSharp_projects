using Microsoft.EntityFrameworkCore;

namespace chefs_and_dishes.Models
{
    public class chefs_and_dishesContext : DbContext
    {
        public chefs_and_dishesContext (DbContextOptions options) : base(options) { }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
