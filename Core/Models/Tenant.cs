using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class Tenant : IdentityUser
{
    public Guid ApartmentId { get; init; }
    public Apartment Apartment { get; init; } = new();
    public DateTime CreatedAt { get; init; } =  DateTime.UtcNow;
    public List<TenantWashroomBooking> TenantWashroomBookings { get; set; } = new();
}