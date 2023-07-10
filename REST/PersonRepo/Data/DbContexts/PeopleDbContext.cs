using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PersonRepo.Data.Models;

namespace PersonRepo.Data.DbContexts;

public class PeopleDbContext : DbContext
{
    public DbSet<Person> People { get; set; } 
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; } 
    public DbSet<Teacher> Teachers { get; set; } 
    public DbSet<Employee> Employees { get; set; } 

    
    public PeopleDbContext()
    {
        
    }
    
    // Connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // get connection string from user secrets
        IConfigurationRoot config = new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetExecutingAssembly())
            .Build();
        
        optionsBuilder.UseSqlServer(config["PersonRepo:DefaultConnection"]);
        
        base.OnConfiguring(optionsBuilder);
    }

    // Fluent API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var employee = modelBuilder.Entity<Employee>();
        var person = modelBuilder.Entity<Person>();
        var student = modelBuilder.Entity<Student>();
        var group = modelBuilder.Entity<Group>();
        var teacher = modelBuilder.Entity<Teacher>();

        group.HasKey(x => x.Id);
        group.Property(x => x.Name).IsRequired();
        group.Property(x => x.Year).HasDefaultValue(1);

        person.HasKey(x => x.Id);
        person.Property(x => x.Name).IsRequired();
        person.Property(x => x.Surname).IsRequired();
        person.Property(x => x.BirthDate).IsRequired();
        person.Ignore(x => x.Age);

        employee.HasKey(x => x.Id);
        employee.Property(x => x.Salary)
            .HasColumnType("smallmoney")
            .HasDefaultValue(3000.0);
        employee.Property(x => x.Position).IsRequired();
        employee.HasOne<Person>(x => x.Person).WithOne();

        student.HasKey(x => x.Id);
        student.Property(x => x.GPA).IsRequired();
        student.HasOne<Person>(x => x.Person).WithOne();
        student.HasOne<Group>(x => x.Group).WithMany(x => x.Students);

        teacher.HasKey(x => x.Id);
        teacher.HasOne<Group>(x => x.Group).WithMany(x => x.Teachers);
        teacher.HasOne<Employee>(x => x.Employee).WithOne();

        base.OnModelCreating(modelBuilder);
    }
}
