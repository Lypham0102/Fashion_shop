using Fashion_shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Fashion_shop.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the composite primary key
            modelBuilder.Entity<Bill_Details>().HasKey(e => new { e.id_details_item, e.Bill_id });
        }
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }



        public DbSet<User> User { get; set; }

        public DbSet<Office> Office { get; set; }

        public DbSet<Fashion_shop.Models.Product_Type> Product_Type { get; set; }

        public DbSet<Fashion_shop.Models.Bill> Bill { get; set; }

        public DbSet<Fashion_shop.Models.Item> Item { get; set; }

        public DbSet<Fashion_shop.Models.Materials> Materials { get; set; }

        public DbSet<Fashion_shop.Models.User_Item> User_Item { get; set; }

        public DbSet<Fashion_shop.Models.Color> Color { get; set; }

        public DbSet<Fashion_shop.Models.Size> Size { get; set; }

        public DbSet<Fashion_shop.Models.Item_Details> Item_Details { get; set; }

        public DbSet<Fashion_shop.Models.Bill_Details> Bill_Details { get; set; }

    }
}
