using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
