using System.ComponentModel.DataAnnotations.Schema;

namespace Kotopes.Domain;

public abstract class Entity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
}