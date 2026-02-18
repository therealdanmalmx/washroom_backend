using Microsoft.AspNetCore.Identity;

namespace Core.DTOs.TenantWashroomBooking;

public class TenantWashroomBookingCreateDto : IdentityUser
{
    public DateOnly Date { get; set; }
    public Guid WashroomScheduleId { get; set; }
}