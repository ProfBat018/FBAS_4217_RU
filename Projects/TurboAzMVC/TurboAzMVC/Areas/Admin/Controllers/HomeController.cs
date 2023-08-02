using Microsoft.AspNetCore.Mvc;

namespace TurboAzMVC.Areas.Admin.Controllers;

public class HomeController : Controller
{
    // GET
    [Area("Admin")]
    public IActionResult Index()
    {
        return View();
    }
}