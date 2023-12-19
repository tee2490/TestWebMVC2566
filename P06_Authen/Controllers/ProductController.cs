using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace P06_Authen.Controllers
{
    
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize] //การยืนยันสิทธิ์
        public IActionResult BuyProduct() 
        { 
            return View();
        }


    }
}
