using Microsoft.AspNetCore.Identity;
using P08_Authorization.Models;

namespace P08_Authorization.Services
{
    public interface IRoleService
    {
        Task<List<IdentityRole>> Get();
        Task<bool> Add(RoleDto roleDto);
        Task<bool> Update(RoleUpdateDto roleUpdateDto);
        Task<bool> Delete(string name);
        Task<IdentityRole> Find(string name);
    }
}
