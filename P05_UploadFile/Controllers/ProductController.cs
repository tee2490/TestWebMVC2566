using Microsoft.AspNetCore.Mvc;
using P05_UploadFile.Settings;

namespace P05_UploadFile.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ps;

        public ProductController(IProductService ps)
        {
            this.ps = ps;
        }

        public async Task<IActionResult> Index()
        {
            return View( await ps.GetProducts() );
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost] //from Submit
        public async Task<IActionResult> Create(Product product, IFormFile file)
        {
           ModelState.Remove("file");
           if (!ModelState.IsValid) return View();

           await ps.Add(product,file);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await ps.Find(id);

            if(product != null) await ps.Delete(product);

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id) 
        {
            var product = await ps.Find(id);

            if(product == null) return RedirectToAction(nameof(Index));
 
            return View(product);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Product product,IFormFile file) 
        {
            ModelState.Remove("file")
;           if(!ModelState.IsValid) return View();

            await ps.Update(product,file);

            return RedirectToAction(nameof(Index));
        }

    }
}
