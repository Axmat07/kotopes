using Kotopes.Domain.Abstractions;

namespace Kotopes.Domain.Models;

public class Shelter : Entity
{
    public string Name { get; set; }
    public string TelephoneNumber { get; set; }
    public string Address { get; set; }
    public string? TelegramId { get; set; }
    public User ModeratorId { get; set; }
}