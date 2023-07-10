using CoreFirst.Models;
using CoreFirst.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreFirst.Pages;

public class Facts : PageModel
{
    public CatsFacts CatsResponse { get; set; } = new();

    private CatsFactsService _catsFactsService;

    public Facts(CatsFactsService catsFactsService)
    {
        _catsFactsService = catsFactsService;
    }

    public async void OnGet()
    {
        try
        {
            CatsResponse = await _catsFactsService.GetFactsAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}