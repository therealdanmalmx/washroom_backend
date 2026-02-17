using Microsoft.AspNetCore.Identity;

namespace Core.DTOs.TenantWashroomBooking;

public class TenantWashroomBookingUpdateDto : IdentityUser
{
    public DateOnly Date { get; set; }
}