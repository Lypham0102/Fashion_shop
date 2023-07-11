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

        public DbSet<Product> Product { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Office> Office { get; set; }

        public DbSet<Fashion_shop.Models.Staff> Staff { get; set; }

        public DbSet<Fashion_shop.Models.Product_Type> Product_Type { get; set; }
    }
}
