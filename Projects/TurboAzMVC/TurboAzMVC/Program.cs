using System.Globalization;
using System.Resources;
using System.Text.Json.Serialization;
using Elfie.Serialization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc()
        .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
        .AddDataAnnotationsLocalization();


builder.Services.AddLocalization(o => o.ResourcesPath = "Resources");


builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    //IEnumerable<CultureInfo> supportedCultures = new CultureInfo[]{ new("en-US"), new("az-AZ"), new("ru-RU") };

    //options.DefaultRequestCulture = new RequestCulture("ru-RU");
    //options.SupportedUICultures = supportedCultures as CultureInfo[];

    string[] supportedCultures = new[] { "en-US", "az-AZ", "ru-RU" };

    options.SetDefaultCulture(supportedCultures[2])
        .AddSupportedCultures(supportedCultures)
        .AddSupportedUICultures(supportedCultures);
    
});




builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<TurboDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TurboAzContext")));



var app = builder.Build();

app.UseRequestLocalization();

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


