using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class Tenant : IdentityUser
{
    public string ApartmentId { get; init; }
    public Apartment Apartment { get; init; }
    public string PropertyId { get; init; }
    public Property Property { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public List<TenantWashroomBooking> TenantWashroomBookings { get; set; } = new();

    public Tenant() { }
    public Tenant(string userName, string email, string phoneNumber, string apartmentId,
        string propertyId)
    {
        UserName = userName;
        Email = email;
        PhoneNumber = phoneNumber;
        ApartmentId = apartmentId;
        PropertyId = propertyId;
    }
}
