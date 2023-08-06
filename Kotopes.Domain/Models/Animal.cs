using Kotopes.Domain.Abstractions;

namespace Kotopes.Domain.Models;

public class Animal : Entity
{
    public string Name { get; set; } = null!;
    public string Owner { get; set; } = null!;
    public string? PhotoKey { get; set; }
    public int Years { get; set; }
    public string Description { get; set; } = null!;
    public bool IsSaveForKids { get; set; }
    public bool IsAllergic { get; set; }
    public Shelter Shelter { get; set; } = null!;
    public long ShelterId { get; set; }
    public string Type { get; set; } = null!;
    public AnimalState AnimalState => AnimalState.New;
}