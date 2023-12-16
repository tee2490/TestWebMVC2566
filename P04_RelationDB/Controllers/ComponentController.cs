using Microsoft.AspNetCore.Mvc;

namespace P04_RelationDB.Controllers
{
    public class ComponentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
