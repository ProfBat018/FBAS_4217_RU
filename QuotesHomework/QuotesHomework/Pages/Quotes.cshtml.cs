using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Text.Json;

namespace QuotesHomework.Pages
{
    public class QuotesModel : PageModel
    {
        public QuotesData Quotes { get; set; }
        public string Author { get; set; }
        public async Task OnGet()
        {
           
        }

        public async Task<IActionResult> OnPost()
        {
            HttpClient client = new();

            var json = await client.GetStringAsync(@"https://type.fit/api/quotes");

            var res = JsonSerializer.Deserialize<QuotesData>(json);

            return RedirectToPage("Quotes", res);
        }
    }
}
