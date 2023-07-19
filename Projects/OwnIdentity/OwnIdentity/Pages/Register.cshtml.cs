using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwnIdentity.Services;

namespace OwnIdentity.Pages;

public class Register : PageModel
{
    private AcademyContext _context;
    
    [BindProperty]
    public User User { get; set; }
    
    public Register(AcademyContext context)
    {
        User = new();
        _context = context;
    }

    public void OnGet()
    {
    }
    
    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        User.Email = Request.Form["email"];
        User.Password = Request.Form["password"];
        User.ConfirmPassword = Request.Form["confirm"];

        try
        {
            User.Password = PasswordService.HashPassword(User.Password);
            _context.Users.Add(User);
            _context.SaveChanges();
            return Page();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return Page();
    }
}