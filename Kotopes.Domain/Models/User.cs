using Kotopes.Domain.Abstractions;

namespace Kotopes.Domain.Models;

public class User : Entity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string TelegramId { get; set; } = null!;
    public string Email { get; set; } = null!;
}