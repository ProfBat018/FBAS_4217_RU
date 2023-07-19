using System.Collections.Immutable;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;

namespace PersonRepo.Services.Classes;

public class EmployeeService : IRepoService<Employee>
{
    public PeopleDbContext Context { get; init; }
    
    public EmployeeService(PeopleDbContext context)
    {
        Context = context;
    }


    public void Add(Employee entity)
    {
        Context.Employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        Context.Employees.Remove(entity);        
    }

    public void Update(Employee entity)
    {
        Context.Update(entity);
    }

    public IAcademyEntity? FindById(int id)
    {
        return Context.Employees.Find(id);
    }

    public Employee? GetFirstOrDefault(Expression<Func<Employee, bool>> filter, string? includeProperties = null, bool tracked = true)
    {
        IQueryable<Employee> query;
        
        if (tracked)
        {
            query = Context.Set<Employee>();
        }
        else
        {
            query = Context.Set<Employee>().AsNoTracking();
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

    public IEnumerable<Employee> GetAll(Expression<Func<Employee, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<Employee> query = Context.Set<Employee>();
        
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