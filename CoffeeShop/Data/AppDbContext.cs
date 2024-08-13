using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContext) :base(dbContext) 
        {
            
        }

         public DbSet<Product> Products { get; set; }
    }
}
