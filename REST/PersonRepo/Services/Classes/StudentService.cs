using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;

namespace PersonRepo.Services.Classes;

public class StudentService : IRepoService<Student>
{
    public PeopleDbContext Context { get; init; }

    public StudentService(PeopleDbContext context)
    {
        Context = context;
    }


    public void Add(Student entity)
    {
        Context.Students.Add(entity);
    }

    public void Delete(Student entity)
    {
        Context.Students.Remove(entity);
    }

    public void Update(Student entity)
    {
        Context.Update(entity);
    }

    public IAcademyEntity? FindById(int id)
    {
        return Context.Students.Find(id);
    }

    public Student? GetFirstOrDefault(Expression<Func<Student, bool>> filter, string? includeProperties = null, bool tracked = true)
    {
        IQueryable<Student> query;
        
        if (tracked)
        {
            query = Context.Set<Student>();
        }
        else
        {
            query = Context.Set<Student>().AsNoTracking();
        }

        query = query.Where(filter);

        if (includeProperties != null)
        {
            foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }

        return query.FirstOrDefault();
    }

    public IEnumerable<Student> GetAll(Expression<Func<Student, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<Student> query = Context.Set<Student>();
        
        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (includeProperties != null)
        {
            foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return query.ToList();
    }
}