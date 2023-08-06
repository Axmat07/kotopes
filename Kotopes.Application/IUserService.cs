using Kotopes.Domain.Models;

namespace Kotopes.Application;

public interface IUserService
{
    Task<long?> AddUser(User user, CancellationToken token);
    Task<bool> DeleteUser(long userId, CancellationToken token);
}