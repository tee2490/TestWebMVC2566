using Microsoft.AspNetCore.Mvc;
using P08_Authorization.Models;
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
        public async Task<IActionResult> Index()
        {
            var result = await _roleService.Get();

            return View(result);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleDto roleDto)
        {
           await _roleService.Add(roleDto);

           return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string name) 
        {
            var result = await _roleService.Find(name);

            if(result == null) return RedirectToAction(nameof(Index));

            var roleUpdate = new RoleUpdateDto { Name = result.Name };

            return View(roleUpdate);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleUpdateDto roleUpdateDto)
        {
           await _roleService.Update(roleUpdateDto);

           return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string name)
        {
            await _roleService.Delete(name);

            return RedirectToAction(nameof(Index));
        }

    }
}
