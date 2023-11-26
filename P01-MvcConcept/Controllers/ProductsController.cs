using Microsoft.AspNetCore.Mvc;
using P01_MvcConcept.IService;

namespace P01_MvcConcept.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService ps;

        //เรียกใช้ DI
        public ProductsController(IProductService ps) 
        {
           this.ps = ps;
        }

      public IActionResult Index()
        {
            ps.GenerateProduct(20);
            return View( ps.GetProductAll() );
        }

        
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost] //ปลายทาง
        public IActionResult Create(Product product)
        {
           return View();
        }


    }
}
