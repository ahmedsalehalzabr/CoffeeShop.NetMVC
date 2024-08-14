using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CoffeeShop.Models;
using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.GetTrendingProducts());
        }
    }
}
