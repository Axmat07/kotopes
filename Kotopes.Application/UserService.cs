using Kotopes.Domain.Abstractions;
using Kotopes.Domain.Models;

namespace Kotopes.Application;

public class UserService : IUserService
{
    private readonly IRepository<User> _repository;

    public UserService(IRepository<User> repository)
    {
        _repository = repository;
    }
    
    public async Task<long?> AddUser(User user, CancellationToken token)
    {
        if (await IsUserExist(user.Email, token))
        {
            return null;
        }
        var id = await _repository.AddAsync(user, token);
        return id;
    }

    public async Task<bool> DeleteUser(long userId, CancellationToken token)
    {
        var result = await _repository.DeleteAsync(userId, token);
        return result;
    }

    private async Task<bool> IsUserExist(string email, CancellationToken token)
    {
        var user = (await _repository.GetAllAsync(token)).FirstOrDefault(u => u.Email == email);
        return user != null;
    }
}