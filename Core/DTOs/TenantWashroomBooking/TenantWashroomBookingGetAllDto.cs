using Microsoft.AspNetCore.Identity;

namespace Core.DTOs.TenantWashroomBooking;

public class TenantWashroomBookingGetAllDto : IdentityUser
{
    public Guid Id { get; set; }
    public DateOnly Date { get; set; }
    public Guid WashroomScheduleId { get; set; }
}