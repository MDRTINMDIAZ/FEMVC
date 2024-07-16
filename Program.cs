using FE.models;
using FE.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Laef4Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("csFE"));
});

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

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
pattern: "{controller=UsuariosLogIn}/{action=LogIn}/{id?}");
//pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
