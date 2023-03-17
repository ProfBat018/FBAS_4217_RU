// HTTP 


#region WebClient

/*
using System.Net;

WebClient WebClient = new(); // class, для загрузки данных из интернета. 

var res = await WebClient.DownloadStringTaskAsync(new Uri(@"http://localhost:3000/users", false));

Console.WriteLine(res);
*/


#endregion

#region HTTP_Client

/*

//HttpClient client = new();

////client.BaseAddress = new(@"http://localhost:3000/users");

//var res = await client.GetAsync(@"http://localhost:3000/users");
//Console.WriteLine(res);

*/

/*
using System.Net.Http.Headers;

var client = new HttpClient();

var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://youtube-to-mp315.p.rapidapi.com/download?url=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3DzyG9Nh_PH38"),
    Headers =
    {
        { "X-RapidAPI-Key", "1ffacf9737mshbb4164b9741187ep1ed703jsn0ece4656d4c4" },
        { "X-RapidAPI-Host", "youtube-to-mp315.p.rapidapi.com" },
    },
    Content = new StringContent("{}")
    {
        Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
    }
};

using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
*/



#endregion
