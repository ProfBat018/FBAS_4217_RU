namespace PersonRepo.Data.Models;

public class Group : IAcademyEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint Year { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<Teacher> Teachers { get; set; }
}