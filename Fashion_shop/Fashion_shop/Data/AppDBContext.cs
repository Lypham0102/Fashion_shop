using Fashion_shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Fashion_shop.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Fashion_shop.Models.Customer> Customer { get; set; }
    }
}
