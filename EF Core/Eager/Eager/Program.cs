using Eager;
using Microsoft.EntityFrameworkCore;


#region IncludeExample

/*
 
// select * from TableName

using WeatherContext context = new();

//var result = context.ForecastHistories.Include(x => x.Forecast).ToList();

var result = context.ForecastHistories.Include("Forecast").ToList();
var result2 = context.ForecastHistories.Include("main").ToList();

foreach (var item in result2)
{
    Console.WriteLine($"{item.Forecast.Name}\t{item.Forecast.Main.Temp}");
}
*/

#endregion


#region GetEfQuery


//using WeatherContext context = new();


//var result2 = context.ForecastHistories
//    .Include(x => x.Forecast)
//    .Include(x => x.Forecast.Main).ToQueryString();



//using FileStream fs = new("log.sql", FileMode.OpenOrCreate);
//using StreamWriter sw = new StreamWriter(fs);

//sw.Write(result2);
#endregion


#region MutiInclude


//using WeatherContext context = new();


//var result = context.ForecastHistories
//    .Include(x => x.Forecast)
//    .Include(x => x.Forecast.Main).ToList();




//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Forecast.Name}\t {item.Forecast.Main.Temp}");
//}

#endregion


#region LINQtoEntity

//using WeatherContext context = new();


//var result = context.ForecastHistories
//    .Include(x => x.Forecast)
//    .Include(x => x.Forecast.Main).ToList();


//SELECT *
//FROM [ForecastHistories] AS[f]
//INNER JOIN [Forecasts] AS [f0] ON[f].[ForecastId] = [f0].[ForecastId]
// INNER JOIN[Main] AS [m] ON[f0].[MainId] = [m].[MainId]



// Sql to entity

//var result = (from f in context.ForecastHistories
//              join forecast in context.ForecastHistories on f.ForecastId equals forecast.Id
//              join main in context.Mains on f.Forecast.MainId equals main.MainId
//              select new 
//              {
//                  Id = f.Id,
//                  Forecast = f.Forecast,
//                  Main = f.Forecast.Main,
//                  ForecastId = f.ForecastId,
//                  SearchTime = f.SearchTime
//              }).ToList();



//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Forecast.Name}\t {item.Forecast.Main.Temp}");
//}

#endregion