using Kotopes.Domain.Abstractions;
using Kotopes.Domain.Models;

namespace Kotopes.Application;

public class ShelterService : IShelterService
{
    private readonly IRepository<Shelter> _repository;

    public ShelterService(IRepository<Shelter> repository)
    {
        _repository = repository;
    }
    public async Task<long?> AddShelter(Shelter shelter, CancellationToken token)
    {
        var result = await _repository.AddAsync(shelter, token);

        return result;
    }
}