using Microsoft.EntityFrameworkCore;
using NotasApp.Models;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Obtener cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("MiConexion");

// Agregar el DbContext al contenedor de dependencias
builder.Services.AddDbContext<RegistroNota>(options =>
    options.UseSqlServer(connectionString));

    
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// agregar servicio de base datos
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
