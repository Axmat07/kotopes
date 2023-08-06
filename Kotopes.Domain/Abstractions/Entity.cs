using System.ComponentModel.DataAnnotations.Schema;

namespace Kotopes.Domain.Abstractions;

public abstract class Entity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
}