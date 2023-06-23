using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Controllers;

// [ApiController]
// [Route("api/[controller]/[action]")]
// public class CarController : ControllerBase
// {
//     // https://localhost:7248/api/Car/GetAll
//     [HttpGet]
//     public IActionResult GetAll()
//     {
//         return Ok("Hello from CarController");
//     }
//     
//     // https://localhost:7248/api/Car/GetCar?id=1&name=Mercedes
//     [HttpGet]
//     public IActionResult GetCar(string id, string name)
//     {
//         return Ok($"Hello from GetCar {id}, {name}");
//     }
//     
//     [HttpPost]
//     public IActionResult Post()
//     {
//         return Ok("Hello from Post");
//     }
// }


// Тоже самое, но теперь давайте принимать параметры в http header

[ApiController]
[Route("api/[controller]/[action]")]

public class CarController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Hello from CarController");
    }
    
    [HttpGet]
    public IActionResult GetCar([FromHeader]string id)
    {
        return Ok($"Hello from GetCar {id}\n");
    }
    
    [HttpPost]
    public IActionResult Post([FromBody]Car car)
    {
        return Ok($"Hello from GetCar {car.Id}\n{car.Make}\n{car.ImageUrl}");
    }
} 