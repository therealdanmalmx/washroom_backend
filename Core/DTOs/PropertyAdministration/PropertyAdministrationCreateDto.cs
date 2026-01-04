namespace Core.DTOs.PropertyAdministration;

public class PropertyAdministrationCreateDto
{
    public required string Name { get; set; }
    public string Logo { get; set; } = string.Empty;
}