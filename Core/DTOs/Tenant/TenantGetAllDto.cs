namespace Core.DTOs.Tenant;

public class TenantGetAllDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid ApartmentId { get; set; }
}