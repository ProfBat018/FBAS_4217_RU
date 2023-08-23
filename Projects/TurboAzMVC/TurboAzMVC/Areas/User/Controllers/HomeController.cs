using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace TurboAzMVC.Areas.User.Controllers;


[Area("User")]
[AllowAnonymous]
public class HomeController : Controller
{
    private TurboDbContext _context;
    private IStringLocalizer<HomeController> _stringLocalizer;

    public HomeController(TurboDbContext context, IStringLocalizer<HomeController> stringLocalizer)
    {
        _context = context;
        _stringLocalizer = stringLocalizer;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult ChangeLang()
    {
        return RedirectToAction("Index");
    }
}