using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace P08_Authorization.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
