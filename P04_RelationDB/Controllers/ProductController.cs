using Microsoft.AspNetCore.Mvc;

namespace P04_RelationDB.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
