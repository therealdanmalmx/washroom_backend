namespace Core.Models;

public class WashRoom
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;
    public Guid PropertyId { get; set; }
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
}