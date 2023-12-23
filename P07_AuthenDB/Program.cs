using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P07_AuthenDB.Areas.Identity.Data;
using P07_AuthenDB.Data;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("AuthenDBContextConnection") ?? throw new InvalidOperationException("Connection string 'AuthenDBContextConnection' not found.");

builder.Services.AddDbContext<AuthenDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MyUser>(options => 
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric= false;
    options.Password.RequiredLength = 3;
}).AddEntityFrameworkStores<AuthenDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
