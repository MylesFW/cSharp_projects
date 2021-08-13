using Microsoft.EntityFrameworkCore;
using products_and_categories.Models;

namespace products_and_categories.Models
{
    public class products_and_categoriesContext : DbContext
    {
        public products_and_categoriesContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Association> Associations { get; set; }
    }
}
