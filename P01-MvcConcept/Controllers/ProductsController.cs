using Microsoft.AspNetCore.Mvc;
using P01_MvcConcept.IService;

namespace P01_MvcConcept.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var ps = new ProductService();
            ps.GenerateProduct(20);

            return View( ps.GetProductAll() );
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
