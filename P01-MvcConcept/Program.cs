global using P01_MvcConcept.Models;
using P01_MvcConcept.IService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. ลงทะเบียน
builder.Services.AddControllersWithViews();

//Dependency injection
builder.Services.AddSingleton<IProductService,ProductService>();


//Middle ware ยาม
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
