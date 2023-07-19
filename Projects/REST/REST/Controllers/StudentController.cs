using Microsoft.AspNetCore.Mvc;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;

namespace REST.Controllers;


[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private IRepoService<Student> _service;

    public StudentController(IRepoService<Student> service)
    {
        _service = service;
    }


    [HttpGet]
    public IActionResult GetData()
    {
        List<Student> students = _service.GetAll(includeProperties: "Person,Group").ToList();
        // List<Student> students = _service.GetAll().ToList();

        return Ok(students);
    }
    
    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        try
        {
            _service.Add(student);
            _service.Save();        
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
