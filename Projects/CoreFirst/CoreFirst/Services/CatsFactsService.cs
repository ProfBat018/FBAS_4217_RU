using System.Text.Json;
using CoreFirst.Models;
using Newtonsoft.Json;

namespace CoreFirst.Services;

public class CatsFactsService
{
    public async Task<CatsFacts> GetFactsAsync()
    {
        string? result;
        HttpClient client = new();

        HttpResponseMessage message = await client.GetAsync("https://cat-fact.herokuapp.com/facts");

        if (message.IsSuccessStatusCode)
        {
            result = await message.Content.ReadAsStringAsync();
            if (result != null)
            {
                var res = JsonConvert.DeserializeObject<CatsFacts>(result);
                return res;
            }
            throw new NullReferenceException();
        }
        throw new HttpRequestException();
    }
}