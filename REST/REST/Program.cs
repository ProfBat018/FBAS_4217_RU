using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;
using PersonRepo.Services.Classes;
using PersonRepo.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Добавляем контекст данных
builder.Services.AddDbContext<PeopleDbContext>(); 

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );
// Добавляем сервис для работы с людьми
// AddTransient - создает новый экземпляр сервиса при каждом обращении к нему
// AddScoped - создает новый экземпляр сервиса для каждого запроса

builder.Services.AddScoped<IRepoService<Person>, PersonService>();
builder.Services.AddScoped<IRepoService<Student>, StudentService>();
builder.Services.AddScoped<IRepoService<Teacher>, TeacherService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

