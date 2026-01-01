namespace Core.Models;

public class TenantWashroomBooking
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int TenantId { get; set; }
    public int WashroomScheduleId { get; set; }
    public DateTime CreatedAt { get; set; } =  DateTime.Now;
}