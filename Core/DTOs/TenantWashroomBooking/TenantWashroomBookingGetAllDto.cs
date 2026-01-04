namespace Core.DTOs.TenantWashroomBooking;

public class TenantWashroomBookingGetAllDto
{
    public Guid Id { get; set; }
    public DateOnly Date { get; set; }
    public Guid TenantId { get; set; }
    public Guid WashroomScheduleId { get; set; }
}