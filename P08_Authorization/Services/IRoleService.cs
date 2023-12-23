using Microsoft.AspNetCore.Identity;

namespace P08_Authorization.Services
{
    public interface IRoleService
    {
        Task<List<IdentityRole>> Get();
    }
}
