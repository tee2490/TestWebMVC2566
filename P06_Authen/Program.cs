using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P06_Authen.Areas.Identity.Data;
using P06_Authen.Data;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("AuthenDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AuthenDbContextConnection' not found.");

builder.Services.AddDbContext<AuthenDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MyUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequiredLength = 3;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AuthenDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();


//MiddleWare คอยตรวจความถูกต้อง คล้ายๆ ยาม
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); //ตรวจสอบการ Login

app.UseAuthorization(); // ยืนยันสิทธิ์

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseEndpoints(endpoints =>endpoints.MapRazorPages());

app.MapRazorPages();

app.Run();
