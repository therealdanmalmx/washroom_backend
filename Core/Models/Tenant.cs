namespace Core.Models;

public class Tenant
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid ApartmentId { get; set; }
    public Apartment Apartment { get; set; } = new();
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
}