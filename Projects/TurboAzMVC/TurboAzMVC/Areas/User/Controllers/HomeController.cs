using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurboAzMVC.Controllers;


[Area("User")]
[AllowAnonymous]
public class HomeController : Controller
{
    private TurboDbContext _context;

    public HomeController(TurboDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
}