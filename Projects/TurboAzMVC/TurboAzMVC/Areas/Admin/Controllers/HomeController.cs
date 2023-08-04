using Microsoft.AspNetCore.Mvc;

namespace TurboAzMVC.Areas.Admin.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
        Console.WriteLine("Admin Home Controller");
    }
    // GET
    [Area("Admin")]
    public IActionResult Index()
    {
        return View();
    }
}