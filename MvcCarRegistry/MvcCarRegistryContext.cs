using Microsoft.EntityFrameworkCore;

public class MvcCarRegistryContext(DbContextOptions<MvcCarRegistryContext> options) : DbContext(options)
{
    public DbSet<MvcCarRegistry.Models.Car> Car { get; set; } = default!;
}
