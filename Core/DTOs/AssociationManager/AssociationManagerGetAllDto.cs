namespace Core.DTOs.AssociationManager;

public class AssociationManagerGetAllDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } =  string.Empty;
    public string Email { get; set; } =  string.Empty;
    public int AssociationId { get; set; }
}