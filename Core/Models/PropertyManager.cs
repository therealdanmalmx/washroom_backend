namespace Core.Models;

public class PropertyManager
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } =  string.Empty;
    public string Email { get; set; } =  string.Empty;
    public int PropertyAdministrationId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}