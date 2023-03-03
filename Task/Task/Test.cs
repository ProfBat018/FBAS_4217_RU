
// Task - задача 

/*
void SayHello()
{
    Console.WriteLine("Hello");
}

var t1 = Task.Run(SayHello);

t1.Wait();
 */


using System.Net;
using System.Text.Json;
using Task;

class Test
{
    public static WeatherForecast GetCityInfo(string cityname)
    {
        WebClient client = new();

        var json = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid=5191fee1957155f779bfd029a4a97e18&units=metric");
    
        WeatherForecast result = JsonSerializer.Deserialize<WeatherForecast>(json);

        return result;

    }
}




