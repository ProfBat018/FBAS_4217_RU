// Метод createBuilder() создает объект WebApplicationBuilder,
// который используется для создания объекта WebApplication.
// По сути тут работает паттерн Builder, который по одному собирает все нужные настройки
// и возвращает готовый объект WebApplication.

// Откуда приходит args ? Он по умолчанию передается в метод Main() и содержит аргументы командной строки.

WebApplicationBuilder builder = WebApplication.CreateBuilder(args); // Строитель веб-приложения 

// Здесь мы добавляем все сервисы, которые будут использоваться в приложении.

builder.Services.AddControllers(); // Говорю, что в приложении будут использоваться контроллеры
builder.Services.AddEndpointsApiExplorer(); // Разрешаю использовать свой API для сторонних приложений внутри сети
builder.Services.AddSwaggerGen(); // Добавляю поддержку Swagger

WebApplication app = builder.Build(); // Говорю строитель построить приложение с параметрами выше 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Добавляю поддержку Swagger
    app.UseSwaggerUI(); // Добавляю поддержку Swagger UI
}

app.UseHttpsRedirection(); // Перенаправляю все запросы с http на https

app.MapControllers(); // Соединяю контроллеры с приложением

app.Run(); // Запускаю приложение