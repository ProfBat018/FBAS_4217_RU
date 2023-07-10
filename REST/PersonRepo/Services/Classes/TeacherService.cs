using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;

namespace PersonRepo.Services.Classes;

public class TeacherService : IRepoService<Teacher>
{
    public PeopleDbContext Context { get; init; }

    public TeacherService(PeopleDbContext context)
    {
        Context = context;
    }


    public void Add(Teacher entity)
    {
        Context.Add(entity);
    }

    public void Delete(Teacher entity)
    {
        Context.Teachers.Remove(entity);
    }

    public void Update(Teacher entity)
    {
        Context.Update(entity);
    }

    public IAcademyEntity? FindById(int id)
    {
        return Context.Teachers.Find(id);
    }

    public Teacher? GetFirstOrDefault(Expression<Func<Teacher, bool>> filter, string? includeProperties = null, bool tracked = true)
    {
        IQueryable<Teacher> query;
        
        if (tracked)
        {
            query = Context.Set<Teacher>();
        }
        else
        {
            query = Context.Set<Teacher>().AsNoTracking();
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

    public IEnumerable<Teacher> GetAll(Expression<Func<Teacher, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<Teacher> query = Context.Set<Teacher>();
        
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