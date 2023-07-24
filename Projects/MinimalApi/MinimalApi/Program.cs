using InstantAPIs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyDbContext>();

builder.Services.AddInstantAPIs(options => options.EnableSwagger = EnableSwagger.Always);

var app = builder.Build();

app.MapInstantAPIs<MyDbContext>();

#region SimpleGet

// app.MapGet("/users", async () =>
// {
    // using var scope = app.Services.CreateScope();
    // var dbContext = scope.ServiceProvider.GetRequiredService<MyDbContext>();

    // var users = await dbContext.Users.ToListAsync();
    // return Results.Ok(users);
// });

#endregion



app.Run();