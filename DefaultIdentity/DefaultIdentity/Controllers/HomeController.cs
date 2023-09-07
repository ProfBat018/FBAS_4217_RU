using System.Diagnostics;
using System.Security.Claims;
using DefaultIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using DefaultIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace DefaultIdentity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<User> _userManager; 
    private readonly IHttpContextAccessor _http;  

    public HomeController(ILogger<HomeController> logger, UserManager<User> userManager, IHttpContextAccessor http)
    {
        _logger = logger;
        _userManager = userManager;
        _http = http;
    }

    public IActionResult Index()
    {
        var claims = _http.HttpContext.User.Claims;

        Claim res = claims.FirstOrDefault(x => x.Value == "elvin.azim@outlook.com");

        if (res != null)
        {
            return View(new CardPartialViewModel());
        }
        else
        {
            return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
        }        
    }

    [Authorize(Roles="Admin")]
    public async Task<IActionResult> Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}