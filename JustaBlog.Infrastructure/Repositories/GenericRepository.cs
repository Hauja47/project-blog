using JustaBlog.Contracts.Interfaces.Repositories;
using JustaBlog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JustaBlog.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public GenericRepository(BlogDbContext context)
    {
        _context = context;
        this.db = this._context.Set<T>();
    }

    private readonly BlogDbContext _context;
    private readonly DbSet<T> db;

    public IEnumerable<T> GetAll()
        => db.AsNoTracking();
    
    public T? GetById(Guid id)
        => db.Find(id);

    public void Insert(T entity)
    {
       db.Add(entity);
    }

    public void Update(T entity)
    {
       db.Update(entity);
    }

    public void Delete(T entity)
    {
        db.Remove(entity);
    }
}