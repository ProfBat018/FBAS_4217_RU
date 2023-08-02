using DbbForTurboAz.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TurboAzMVC.Areas.Api.Controllers;

[Area("Api")]
[AllowAnonymous]
public class CarController : Controller
{
    private TurboDbContext _context;
    public CarController(TurboDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return Json("Hello from CarController");
    }
    
    [HttpPost]
    public async Task<IActionResult> AddCar([FromBody] Car car)
    {
        try
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return RedirectToPage("Error", new ErrorViewModel()
            {
                Message = ex.Message,
                StackTrace = ex.StackTrace
            });
        }
        return Ok("success");
    }
}