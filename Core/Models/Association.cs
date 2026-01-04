namespace Core.Models;

public class Association
{ 
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}