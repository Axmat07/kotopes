using Kotopes.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Kotopes.Persistance;

public class EfRepository<T> : IRepository<T> where T : Entity
{
    private readonly DbContext _dataContext;
    public EfRepository(DbContext dataContext)
    {
        _dataContext = dataContext;
    }
    
    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken token)
    {
        return await _dataContext.Set<T>().ToListAsync(token);
    }

    public async Task<T?> GetAsync(long id, CancellationToken token)
    {
        return await _dataContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, token);
    }

    public async Task<long?> AddAsync(T entity, CancellationToken token)
    {
        var result = await _dataContext.Set<T>().AddAsync(entity, token);
        await _dataContext.SaveChangesAsync(token);
        var id = result.Entity.Id;
        return id;
    }

    public async Task UpdateAsync(T entity, CancellationToken token)
    {
        await _dataContext.SaveChangesAsync(token);
    }

    public async Task<bool> DeleteAsync(long id, CancellationToken token)
    {
        var entity = await _dataContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, token);
        if (entity == null)
        {
            return false;
        }
        
        _dataContext.Set<T>().Remove(entity);
        await _dataContext.SaveChangesAsync();
        
        return true;

    }
}