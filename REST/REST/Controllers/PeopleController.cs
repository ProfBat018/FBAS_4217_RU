using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;
using PersonRepo.Data.Models;

namespace REST.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private IRepoService<Person> _service;

    public PeopleController(IRepoService<Person> service)
    {
        _service = service;
    }


    [HttpGet]
    public IActionResult GetData()
    {
        List<Person> people = _service.GetAll().ToList();
        
        return Ok(people);
    }
    
    [HttpPost]
    public IActionResult AddPerson(Person person)
    {
        try
        {
            _service.Add(person);
            _service.Save();        
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
