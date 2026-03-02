namespace Core.Models;

public class Property
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public Guid PropertyAdministrationId { get; set; }
    public PropertyAdministration? PropertyAdministration { get; set; }
    public Guid? AssociationManagerId { get; set; }
    public AssociationManager? AssociationManager { get; set; }
    public List<Apartment> Apartments { get; set; } = new();
    public List<WashRoom> WashRooms { get; set; } = new();
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
}