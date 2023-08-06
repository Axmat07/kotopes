using Kotopes.Domain.Models;

namespace Kotopes.Application;

public interface IUserService
{
    Task<long?> AddUser(User user);
    Task<bool> DeleteUser(long userId);
}