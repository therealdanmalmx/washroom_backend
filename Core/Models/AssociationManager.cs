namespace Core.Models;

public class AssociationManager
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } =  string.Empty;
    public string Email { get; set; } =  string.Empty;
    public Guid AssociationId { get; set; }
    public Association Association { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Property> Properties { get; set; } = new();
}