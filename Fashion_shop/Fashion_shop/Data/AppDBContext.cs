using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fashion_shop.Data
{
    
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDBContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
