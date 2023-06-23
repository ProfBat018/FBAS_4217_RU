# Темы урока
* IOC/DI
* MVC
* Middleware
* Routing


## IOC/DI

IOC - Inversion of Control
DI - Dependency Injection

Инверсия управления - это когда наш сервис управляется внешними зависимостями.

Приммер
```csharp
public class RegistrationService
{
    private readonly ILogger _logger;
    public RegistrationService(ILogger logger)
    {
        _logger = logger;
    }
}
```

Внедрение зависимостей - это когда мы передаем зависимости в конструктор.
В нашем случае, мы использовали такие DI контейнеры как: 
* SimpleInjector
* Microsoft.Extensions.DependencyInjection

Эти DI контейнеры позволяют нам регистрировать зависимости в контейнере и получать их из контейнера.
При этом все параметры конструктора будут автоматически подставлены.


## Виды регистрации зависимостей
* AddSingleton - создает один экземпляр сервиса и возвращает его при каждом обращении
* AddScoped - создает один экземпляр сервиса на каждый сеанс
* AddTransient - создает новый экземпляр сервиса при каждом обращении


В `Microsoft.Extensions.DependencyInjection` есть возможность регистрировать DB с помощью метода `AddDbContext`.
Под капотом этот метод регистрирует зависимость как `AddScoped`.


## Что такое Middleware ? 
Middleware - это подпрограмма, которая обрабатывает наш запрос 
и передает следующему Middleware в цепочке.

Сам Middleware - работает по паттерну ***Chain of Responsibility.***

В ASP.NET Core Middleware - это классы, которые реализуют интерфейс `IMiddleware` или `IMiddleware<T>`.

Каждый Middleware имеет метод `Invoke` и  делегат на следующий Middleware в цепочке.

## Что такое MVC ?

MVC - Model View Controller

Model, он и в Африке Model. Это наша модель данных, которая будет передаваться во View.
View, он и в Африке View. Это наша View, которая будет отображать данные. Например html страница.
Controller,  нужен для того, чтобы категоризировать наши запрсы.

Например, у нас есть контроллер `UserController` и `ProductController`.
У обоих есть `View`, который назывется `Home`.

Как будет выглядеть запрос ?

1. localhost:5000/User/Home
2. localhost:5000/Product/Home

При этом все работает с поощью рефлексии.

User - UserController
Product - ProductController

Home - это методы внутри контроллеров, который возвращают `ViewResult`.


