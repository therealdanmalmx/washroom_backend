namespace Core.DTOs.Property;

public class PropertyCreateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int PropertyAdministrationId { get; set; }
    public int AdssociationManagerId { get; set; }
}