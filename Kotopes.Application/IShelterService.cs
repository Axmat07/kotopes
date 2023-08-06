using Kotopes.Domain.Models;

namespace Kotopes.Application;

public interface IShelterService
{
    Task<long?> AddShelter(Shelter shelter, CancellationToken token);
}