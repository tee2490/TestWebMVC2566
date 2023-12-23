using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace P08_Authorization.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<MyUser> _userManager;

        public RoleService(RoleManager<IdentityRole> roleManager, UserManager<MyUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<List<IdentityRole>> Get()
        {
           return await _roleManager.Roles.ToListAsync();
        }
    }
}
