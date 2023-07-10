using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;
using PersonRepo.Services.Interfaces;

namespace PersonRepo.Services.Classes;

public class GroupService : IRepoService<Group>
{
    public PeopleDbContext Context { get; init; }

    public GroupService(PeopleDbContext context)
    {
        Context = context;
    }


    public void Add(Group entity)
    {
        Context.Groups.Add(entity);
    }

    public void Delete(Group entity)
    {
        Context.Groups.Remove(entity);
    }

    public void Update(Group entity)
    {
        Context.Update(entity);
    }

    public IAcademyEntity? FindById(int id)
    {
       return Context.Groups.Find(id);
    }

    public Group? GetFirstOrDefault(Expression<Func<Group, bool>> filter, string? includeProperties = null, bool tracked = true)
    {
        IQueryable<Group> query;
        
        if (tracked)
        {
            query = Context.Set<Group>();
        }
        else
        {
            query = Context.Set<Group>().AsNoTracking();
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

    public IEnumerable<Group> GetAll(Expression<Func<Group, bool>>? filter = null, string? includeProperties = null)
    {
        IQueryable<Group> query = Context.Set<Group>();
        
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