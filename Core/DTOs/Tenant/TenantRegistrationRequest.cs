namespace Core.DTOs.Tenant;

public class TenantRegistrationRequest
{
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Password { get; set; }
    public required string ConfirmPassword { get; set; }
    public required Guid ApartmentId { get; init; }
    public required Guid PropertyId { get; set; }
    public DateTime CreatedAt { get; init; } =  DateTime.UtcNow;
    public List<Models.TenantWashroomBooking> TenantWashroomBookings { get; set; } = new();
}