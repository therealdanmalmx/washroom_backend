using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class Tenant : IdentityUser
{
    public Guid ApartmentId { get; init; }
    public Apartment Apartment { get; init; }
    public Guid PropertyId { get; init; }
    public Property Property { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public List<TenantWashroomBooking> TenantWashroomBookings { get; set; } = new();

    public Tenant() { }
    public Tenant(string userName, string email, string phoneNumber, Guid apartmentId,
        Guid propertyId)
    {
        UserName = userName;
        Email = email;
        PhoneNumber = phoneNumber;
        ApartmentId = apartmentId;
        PropertyId = propertyId;
    }
}
