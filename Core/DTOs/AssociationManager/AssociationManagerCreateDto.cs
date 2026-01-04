namespace Core.DTOs.AssociationManager;

public class AssociationManagerCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } =  string.Empty;
    public string Email { get; set; } =  string.Empty;
    public int AssociationId { get; set; }
}