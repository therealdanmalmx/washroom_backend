namespace Core.DTOs.Association;

public class AssociationGetAllDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}