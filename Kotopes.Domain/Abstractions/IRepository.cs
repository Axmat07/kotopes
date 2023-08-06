namespace Kotopes.Domain.Abstractions;

public interface IRepository<T> where T : Entity
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken token);
    
    Task<T?> GetAsync(long id, CancellationToken token);
    
    Task<long?> AddAsync(T entity, CancellationToken token);
    
    Task UpdateAsync(T entity, CancellationToken token);
    
    Task<bool> DeleteAsync(long id, CancellationToken token);
}