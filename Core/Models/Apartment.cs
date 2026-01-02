namespace Core.Models;

public class Apartment
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public int PropertyId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}