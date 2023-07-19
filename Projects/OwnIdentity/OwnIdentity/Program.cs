using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OwnIdentity;
using OwnIdentity.Pages;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Configuration.AddEnvironmentVariables()
    .AddUserSecrets(Assembly.GetExecutingAssembly(), true);


Console.WriteLine(builder.Configuration["DefaultConnection"]);

builder.Services.AddDbContext<AcademyContext>(opts => 
    opts.UseSqlServer(builder.Configuration["DefaultConnection"]));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();