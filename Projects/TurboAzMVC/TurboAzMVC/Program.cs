using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TurboAzMVC.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<TurboDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TurboAzContext")));

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{area=User}/{controller=Home}/{action=Index}/");

// app.MapAreaControllerRoute(
//     name: "default",
//     areaName: "User",
//     pattern: "{area=User}/{controller=Home}/{action=Index}");
//
// app.MapAreaControllerRoute(
//     name: "Api",
//     areaName: "Api",
//     pattern: "{area=Api}/{controller=Car}/{action=GetAllCarsAsync}");
//
// app.MapAreaControllerRoute(
//     name: "Admin",
//     areaName: "Admin",
//     pattern: "{area=Admin}/{controller=Home}/{action=Index}");

app.Run();


