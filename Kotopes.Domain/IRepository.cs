namespace Kotopes.Domain;

public interface IRepository<T> where T : Entity
{
    Task<IEnumerable<T>> GetAllAsync();
    
    Task<T?> GetAsync(long id);
    
    Task<long?> AddAsync(T entity);
    
    Task UpdateAsync(T entity);
    
    Task<bool> DeleteAsync(long id);
}