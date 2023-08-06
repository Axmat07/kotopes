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
    
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dataContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetAsync(long id)
    {
        return await _dataContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<long?> AddAsync(T entity)
    {
        var result = await _dataContext.Set<T>().AddAsync(entity);
        await _dataContext.SaveChangesAsync();
        var id = result.Entity.Id;
        return id;
    }

    public async Task UpdateAsync(T entity)
    {
        await _dataContext.SaveChangesAsync();
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await _dataContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        if (entity == null)
        {
            return false;
        }
        
        _dataContext.Set<T>().Remove(entity);
        await _dataContext.SaveChangesAsync();
        
        return true;

    }
}