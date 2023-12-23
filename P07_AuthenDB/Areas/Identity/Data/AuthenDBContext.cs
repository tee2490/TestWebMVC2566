using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P07_AuthenDB.Areas.Identity.Data;

namespace P07_AuthenDB.Data;

public class AuthenDBContext : IdentityDbContext<MyUser>
{
    public AuthenDBContext(DbContextOptions<AuthenDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<MyUser> MyUsers { get; set; }
}
