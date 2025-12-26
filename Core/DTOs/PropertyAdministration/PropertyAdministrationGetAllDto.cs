namespace Core.DTOs.PropertyAdministration;

public class PropertyAdministrationGetAllDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Logo { get; set; } = string.Empty;
}