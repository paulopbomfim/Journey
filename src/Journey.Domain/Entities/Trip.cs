namespace Journey.Domain.Entities;

public class Trip
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; init; }
}