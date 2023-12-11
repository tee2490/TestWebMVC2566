using Microsoft.AspNetCore.Mvc;
using P03_CodeFirst.Models;
using P03_CodeFirst.Services;

namespace P03_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ps;

        public ProductController(IProductService ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            var products = ps.GetAll();

            return View(products);
        }

        public IActionResult Delete(int id) {
            var product = ps.GetById(id);

            if(product == null) 
            {
                TempData["OK"] = true; //นำไปใช้ที่หน้า View ชั่วคราว
            }
            else {
                ps.Delete(product);
            }

            return RedirectToAction("Index");
        }

       
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost] //กด Submit ให้มาที่นี้
        public IActionResult Create(Product product)
        {
            if(!ModelState.IsValid) return View();
           
            ps.Add(product);

            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id) 
        {
            var product = ps.GetById(id);

            if (product == null)
            {
                TempData["OK"] = true; //นำไปใช้ที่หน้า View ชั่วคราว
            }
            
            return View(product);

        }

        [HttpPost]
        public IActionResult Edit(Product product) 
        { 
            if(!ModelState.IsValid) return View();

            ps.Update(product);

            return RedirectToAction("Index");
        }


    }
}

