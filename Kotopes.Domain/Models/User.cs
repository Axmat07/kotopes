using Kotopes.Domain.Abstractions;

namespace Kotopes.Domain.Models;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TelegramId { get; set; }
    public string Email { get; set; }
}