namespace Core.DTOs.TenantWashroomBooking;

public class TenantWashroomBookingCreateDto
{
    public DateOnly Date { get; set; }
    public Guid TenantId { get; set; }
    public Guid WashroomScheduleId { get; set; }
}