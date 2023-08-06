namespace Kotopes.Domain;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TelegramId { get; set; }
    public string Email { get; set; }
}