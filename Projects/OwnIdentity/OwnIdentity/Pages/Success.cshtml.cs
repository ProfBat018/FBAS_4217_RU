using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OwnIdentity;

public class Success : PageModel
{
    public async Task<IActionResult> OnGet()
    {
        await Task.Delay(1000);
        return RedirectToPage("Login");
    }
}