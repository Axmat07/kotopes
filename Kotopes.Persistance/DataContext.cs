using Kotopes.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options ) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}