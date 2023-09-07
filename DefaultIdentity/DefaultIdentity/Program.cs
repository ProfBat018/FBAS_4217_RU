using DefaultIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DefaultIdentity.Data;
using DefaultIdentity.Models;
using DefaultIdentity.Services.Classes;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("UserContextConnection") ?? throw new InvalidOperationException("Connection string 'UserContextConnection' not found.");

builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = new PathString("/Identity/Account/AccessDenied");
    options.LoginPath = new PathString("/Identity/Account/Login");
    options.AccessDeniedPath = new PathString("/Identity/Account/AccessDenied");
});



builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddSingleton<IEmailSender, EmailSender>();
builder.Services.AddSingleton<User>();

builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<User, IdentityRole>().AddDefaultTokenProviders()
    .AddEntityFrameworkStores<UserContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
    
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();