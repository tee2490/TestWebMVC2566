using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new List<Product>()
            {
               new Product() {Id=1,Name="Coffee1",Price=100,Amount=20},
               new Product() {Id=2,Name="Coffee2",Price=200,Amount=20},
            };

            return View(product);
        }
    }
}
