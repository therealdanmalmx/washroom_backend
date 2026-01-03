namespace Core.Models;

public class Association
{ 
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}