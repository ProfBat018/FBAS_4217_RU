using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DefaultIdentity.Models;
using Microsoft.AspNetCore.Authorization;

namespace DefaultIdentity.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductsController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public async Task<IActionResult> Index()
    {
        return View();
    }
}