using FluentValidation;
using FluentValidationExample.Data.DbContexts;
using FluentValidationExample.Data.Models;
using FluentValidationExample.Data.Validators;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IValidator<User>, UserValidator>();


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EcommerceContext>(opts => opts.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultDb")));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();