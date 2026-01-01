namespace Core.DTOs.TenantWashroomBooking;

public class TenantWashroomBookingGetAllDto
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int TenantId { get; set; }
    public int WashroomScheduleId { get; set; }
}