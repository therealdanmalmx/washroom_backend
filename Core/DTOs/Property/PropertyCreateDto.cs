namespace Core.DTOs.Property;

public class PropertyCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public Guid PropertyAdministrationId { get; set; }
    public Guid AssociationManagerId { get; set; }
}