using Microsoft.EntityFrameworkCore;

namespace login_and_registration.Models
{
    public class login_and_registrationContext : DbContext
    {
        public login_and_registrationContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
