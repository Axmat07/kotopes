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
    
    public async Task<long?> AddUser(User user)
    {
        if (await IsUserExist(user.Email))
        {
            return null;
        }
        var id = await _repository.AddAsync(user);
        return id;
    }

    public async Task<bool> DeleteUser(long userId)
    {
        var result = await _repository.DeleteAsync(userId);
        return result;
    }

    private async Task<bool> IsUserExist(string email)
    {
        var user = (await _repository.GetAllAsync()).FirstOrDefault(u => u.Email == email);
        return user != null;
    }
}