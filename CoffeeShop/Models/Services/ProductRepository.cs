using CoffeeShop.Data;
using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
           return dbContext.Products.ToList();
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(c => c.IsTrendingProduct).ToList();
        }
    }
}
