namespace Core.DTOs.PropertyAdministration;

public class PropertyAdministrationUpdateDto
{
    public required string Name { get; set; }
    public string Logo { get; set; } = string.Empty;
}