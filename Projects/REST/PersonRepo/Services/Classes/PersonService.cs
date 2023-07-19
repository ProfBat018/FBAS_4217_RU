using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;

namespace PersonRepo.Services.Classes;

public class PersonService : IRepoService<Person>
{
    public PeopleDbContext Context { get; init; }
    
    public PersonService(PeopleDbContext context)
    {
        Context = context;
    }


    public void Add(Person entity)
    {
        Context.People.Add(entity);
    }

    public void Delete(Person entity)
    {
        Context.People.Remove(entity);
    }

    public void Update(Person entity)
    {
        Context.Update(entity);
    }

    public IAcademyEntity? FindById(int id)
    {
        return Context.People.Find(id);
    }

    public Person? GetFirstOrDefault(Expression<Func<Person, bool>> filter, string? includeProperties = null, bool tracked = true)
    {
        IQueryable<Person> query;
        
        if (tracked)
        {
            query = Context.Set<Person>();
        }
        else
        {
            query = Context.Set<Person>().AsNoTracking();
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

    public IEnumerable<Person> GetAll(Expression<Func<Person, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<Person> query = Context.Set<Person>();
        
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