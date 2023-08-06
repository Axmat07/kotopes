using Kotopes.Domain.Abstractions;

namespace Kotopes.Domain.Models;

public class Animal : Entity
{
    public string Name { get; set; }
    public string Owner { get; set; }
    public string? PhotoKey { get; set; }
    public int Years { get; set; }
    public string Description { get; set; }
    public bool IsSaveForKids { get; set; }
    public bool IsAllergic { get; set; }
    public Shelter Shelter { get; set; }
    public long shelterId { get; set; }
    public string Type { get; set; }
    public AnimalState AnimalState => AnimalState.New;
}