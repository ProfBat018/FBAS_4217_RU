using System.Text;
using System.Text.Json;
using CoreFirst.Models;
using Newtonsoft.Json;

namespace CoreFirst.Services;

public class CatsFactsService
{
    public async Task<CatsFacts> GetFactsAsync()
    {
        StringBuilder? result;
        HttpClient client = new();

        HttpResponseMessage message = await client.GetAsync("https://cat-fact.herokuapp.com/facts");

        if (message.IsSuccessStatusCode)
        {
            result = new( await message.Content.ReadAsStringAsync());
            result.Insert(0, """{ "results": """);
            result.Append("}");

            var json = result.ToString();
            if (result != null)
            {
                var res = JsonConvert.DeserializeObject<CatsFacts>(json);
                return res;
            }
            throw new NullReferenceException();
        }
        throw new HttpRequestException();
    }
}