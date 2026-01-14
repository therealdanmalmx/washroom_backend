namespace Core.Models;

public class PropertyManager
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } =  string.Empty;
    public string Email { get; set; } =  string.Empty;
    public Guid PropertyAdministrationId { get; set; }
    public PropertyAdministration? PropertyAdministration { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}