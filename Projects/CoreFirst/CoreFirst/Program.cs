// Создаем строителя для нашего Web сайта.
// Он в дальнейшем будет использоваться для создания объекта WebApplication.

using CoreFirst.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервис для работы с razor 
builder.Services.AddRazorPages();

builder.Services.AddTransient<CatsFactsService>(); // Добавляем сервис для работы с API

// Собираем наш WebApplication
var app = builder.Build();

// Если мы в не в режиме разработки, то добавляем обработчик ошибок и включаем HTTPS
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // HSTS - HTTP Strict Transport Security
    app.UseHsts();
}

app.UseHttpsRedirection(); // Если запрос идет по HTTP, то перенаправляем на HTTPS
app.UseStaticFiles(); // Все файлы в папке wwwroot будут доступны по прямым ссылкам
app.UseRouting(); // Добавляем маршрутизацию. Например, если в запросе указан путь /Home/Index, то будет вызван метод Index класса Home
app.UseAuthorization(); // Добавляем авторизацию на будущее. 

app.MapRazorPages(); // Связываем Razor с нашим приложением

app.Run(); // Запускаем приложение
