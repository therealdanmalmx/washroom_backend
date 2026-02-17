using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class Tenant : IdentityUser
{
    [StringLength((12))]
    public string Phone { get; set; } = string.Empty;
    public Guid ApartmentId { get; set; }
    public Apartment Apartment { get; set; } = new();
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
    public List<TenantWashroomBooking> TenantWashroomBookings { get; set; } = new();
}