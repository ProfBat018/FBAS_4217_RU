using System.Reflection;
using System.Text.Json;

var info = typeof(HttpClient);

var ctors = info.GetConstructors();

foreach (var item in ctors)
{
	foreach (var j in item.GetParameters())
	{
		Console.WriteLine(j.ParameterType);
	}
}

