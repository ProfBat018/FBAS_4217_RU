using Lazy;

using WeatherContext context = new();

var result = context.ForecastHistories.ToList();


foreach (var item in result)
{
    Console.WriteLine($"{item.Forecast.Name}\t{item.Forecast.Main.Temp}");
}




