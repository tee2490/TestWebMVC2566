using Microsoft.AspNetCore.Mvc;
using P08_Authorization.Services;

namespace P08_Authorization.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
