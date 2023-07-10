using System.Linq.Expressions;
using PersonRepo.Data.DbContexts;
using PersonRepo.Data.Models;

namespace PersonRepo.Services.Interfaces;

public interface IRepoService<T> where T : IAcademyEntity
{
    public PeopleDbContext Context { get; init; }
    public void Add(T entity);
    public void Delete(T entity);
    public void Update(T entity);
    public IAcademyEntity? FindById(int id);
    
    // GetFirstOrDefault() - возвращает первый элемент последовательности, удовлетворяющий заданному условию.
    // Если он не находит ни одного элемента, то возвращает значение по умолчанию для типа T.
    T? GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeProperties = null, bool tracked = true);
    IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string includeProperties = null);

    public void Save()
    {
        Context.SaveChanges();
    }
}

/*
    Как работает Expression<Func<T, bool>> filter?
    Вот пример:
    Expression<Func<int, bool>> filter = x => x > 5;
    
    Пример работы GetAll() с filter:
    var result = GetFirstOrDefault(x => x.Id == 1);
*/