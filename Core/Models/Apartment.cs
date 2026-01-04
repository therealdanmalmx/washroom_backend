namespace Core.Models;

public class Apartment
{
    public Guid Id { get; set; } =  Guid.CreateVersion7();
    public string Number { get; set; } = string.Empty;
    public int PropertyId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}