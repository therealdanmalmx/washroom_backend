namespace Core.Models;

public class TenantWashroomBooking
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public DateOnly Date { get; set; }
    public Guid TenantId { get; set; }
    public Guid WashroomScheduleId { get; set; }
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
}