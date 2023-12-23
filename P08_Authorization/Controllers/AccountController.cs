using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace P08_Authorization.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MyUser> _userManager;

        public AccountController(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            return View(users);
        }
    }
}
