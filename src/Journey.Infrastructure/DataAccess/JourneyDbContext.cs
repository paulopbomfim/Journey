using Journey.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure.DataAccess;

internal class JourneyDbContext : DbContext
{
    public JourneyDbContext(DbContextOptions options): base(options) {}
    
    public DbSet<Trip> Trips { get; init; }
}