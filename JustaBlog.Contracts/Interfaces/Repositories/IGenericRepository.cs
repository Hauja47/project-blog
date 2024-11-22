namespace JustaBlog.Contracts.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    public IEnumerable<T> GetAll();
    public T? GetById(Guid id);
    public void Insert(T entity);
    public void Update(T entity);
    public void Delete(T entity);
}