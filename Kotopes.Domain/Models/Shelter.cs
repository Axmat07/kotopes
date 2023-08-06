using Kotopes.Domain.Abstractions;

namespace Kotopes.Domain.Models;

public class Shelter : Entity
{
    public string Name { get; set; } = null!;
    public string TelephoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string? TelegramId { get; set; }
    public User ModeratorId { get; set; } = null!;
}