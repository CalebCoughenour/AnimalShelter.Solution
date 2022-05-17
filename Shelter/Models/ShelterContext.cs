using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ShelterContext(DbContextOptions options) : base(options) { }
  }
}