using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FluentValidationExample.Models;
using Microsoft.AspNetCore.Localization;
using FluentValidation;
using FluentValidationExample.Data.Models;
using FluentValidationExample.Extensions;

namespace FluentValidationExample.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IValidator<User> _validator;


    public HomeController(ILogger<HomeController> logger, IValidator<User> validator)
    {
        _logger = logger;
        _validator = validator;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(User user)
    {
        var result = await _validator.ValidateAsync(user);

        if (result.IsValid)
        {
            return Ok();
        }
        result.AddToModelState(this.ModelState); 

        return View("Index");
    }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    } 

