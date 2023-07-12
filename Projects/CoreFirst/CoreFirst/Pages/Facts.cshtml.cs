using System.Runtime.InteropServices.JavaScript;
using CoreFirst.Models;
using CoreFirst.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace CoreFirst.Pages;

public class Facts : PageModel
{
    public CatsFacts CatsResponse { get; set; } = new();

    private CatsFactsService _catsFactsService;

    public Facts(CatsFactsService catsFactsService)
    {
        _catsFactsService = catsFactsService;
    }

    public async Task<IActionResult> OnGet()
    {
        try
        {
            CatsResponse = await _catsFactsService.GetFactsAsync();
        }
        catch (Exception e)
        {
            throw new JsonException(e.Message);
        }
        return Page();
    }
}