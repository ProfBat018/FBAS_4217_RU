# Тема урока: FluentValidation

FluentValidation - это библиотека, которая позволяет нам валидировать модели в ASP.NET Core приложениях. Она позволяет нам валидировать модели, используя Fluent API, а также позволяет нам создавать собственные валидаторы.

Зачем нам нам валидация от FluentValidation, если есть валидация по атрибутам(де факто обычная валидация от ASP.NET Core)

Напоминаю как это выглядит на примере класса User 

```csharp

class User {

[Required]
[MaxLength(30)]
[Regex(@"^[a-zA-Z0-9]+$")]
public string Name {get;set;}
}


class HomeController : ControllerBase {

[HttpPost]
public IActionResult Index([FromBody]User user) {

if(!ModelState.IsValid) {
	return BadRequest(ModelState);
}
else {
	return Ok();
}

}


```
