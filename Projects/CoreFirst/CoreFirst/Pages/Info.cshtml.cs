using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreFirst.Pages;

public class Info : PageModel
{
    public string Name { get; set; }
    
    public void OnGet()
    {
        Name = "Ayxan";
    }
}