namespace Core.Models;

public class WashRoom
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int PropertyId { get; set; }
    public DateTime CreatedAt { get; set; } =  DateTime.Now;
}