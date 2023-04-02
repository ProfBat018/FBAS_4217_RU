using System.Net;
using System.Text.Json;
using System.Threading.Channels;

// Get - Берет данные с сервера
// Post - Отправляет данные на сервер
// Put - Обновляет данные на сервере
// Delete - Удаляет данные на сервере

// Head - Возвращает заголовки ответа
// Options - Возвращает список методов, которые поддерживает сервер
// Trace - Возвращает сообщение, которое отправил сервер
// Connect - Устанавливает прокси-соединение

// http client to do request to a json api

var client = new HttpClient();

HttpResponseMessage response = await client.GetAsync("http://localhost:3001/Users");

if (response.IsSuccessStatusCode)
{
    Console.WriteLine(await response.Content.ReadAsStringAsync());
}

// foreach(var header in response.Headers)
// {
//     Console.WriteLine($"{header.Key}: {header.Value.First()}");
// }
