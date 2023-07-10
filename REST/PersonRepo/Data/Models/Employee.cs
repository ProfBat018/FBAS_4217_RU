namespace PersonRepo.Data.Models;

public class Employee : IAcademyEntity
{
    public int Id { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    
    public int PersonId { get; set; }
    public Person Person { get; set; }
}