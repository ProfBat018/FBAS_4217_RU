using System.Text.Json;
using JWT.Models;
using JWT.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(AccountLoginViewModel loginViewModel)
    {
        if (ModelState.IsValid)
        {
            using FileStream fs = new("data.txt", FileMode.Open);
            using StreamReader sr = new(fs);
            
            var user = JsonSerializer.Deserialize<AccountLoginViewModel>(sr.ReadToEnd());
            
            if (user.Username == loginViewModel.Username && PasswordHasher.VerifyPassword(user.Password, loginViewModel.Password))
            {
                var roles = new string[] {"Admin", "User"};
                // var jwtToken = Authentication.GenerateJwtToken(user.Username, roles);
            }
        }
        return View();
    }
    
    
    public async Task<IActionResult> Register()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
    {
        if (ModelState.IsValid && registerViewModel.AccountLoginViewModel.Password == registerViewModel.ConfirmPassword)
        {
            using FileStream fs = new("users.json", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);

            registerViewModel.AccountLoginViewModel.Password =
                PasswordHasher.HashPassword(registerViewModel.AccountLoginViewModel.Password);
            
            string json = JsonSerializer.Serialize(registerViewModel.AccountLoginViewModel);
            
            await sw.WriteAsync(json);
        }
        return View();
    }
}