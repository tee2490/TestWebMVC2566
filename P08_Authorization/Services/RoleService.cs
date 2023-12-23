using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P08_Authorization.Models;

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

        public async Task<bool> Add(RoleDto roleDto)
        {
            var role = new IdentityRole
            {
                Name = roleDto.Name,
                NormalizedName = _roleManager.NormalizeKey(roleDto.Name)
            };

            var result = await _roleManager.CreateAsync(role);

            if (!result.Succeeded) return false;

            return true;
        }

        public async Task<bool> Delete(string name)
        {
            var role = await Find(name);

            if(role == null) return false;    

            var result = await _roleManager.DeleteAsync(role);

            if (!result.Succeeded) return false;

            return true;
        }

        public async Task<IdentityRole> Find(string name)
        {
            return await _roleManager.FindByNameAsync(name);
        }

        public async Task<List<IdentityRole>> Get()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<bool> Update(RoleUpdateDto roleUpdateDto)
        {
            var role = await Find(roleUpdateDto.Name);

            if (role == null) return false;

            role.Name = roleUpdateDto.NameUpdate;
            role.NormalizedName = _roleManager.NormalizeKey(roleUpdateDto.NameUpdate);

            var result = await _roleManager.UpdateAsync(role);

            if (!result.Succeeded) return false;

            return true;
        }

    }
}
