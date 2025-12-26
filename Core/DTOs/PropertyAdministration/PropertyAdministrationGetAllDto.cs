namespace Core.DTOs.PropertyAdministration;

public class PropertyAdministrationGetAllDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public string Logo { get; set; } = string.Empty;
}