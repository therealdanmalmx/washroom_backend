using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class Apartment
{
    public Guid Id { get; set; } =  Guid.CreateVersion7();
    [StringLength((10))]
    public string Number { get; set; } = string.Empty;
    public Guid? PropertyId { get; set; }
    public Property? Property { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Tenant>? Tenants { get; set; }
}