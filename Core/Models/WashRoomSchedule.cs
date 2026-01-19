namespace Core.Models;

public class WashRoomSchedule
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid  WashRoomId { get; set; }
    public WashRoom WashRoom { get; set; } = new();
    public Guid ScheduleId { get; set; }
    public Schedule Schedule { get; set; } = new();
    public DateTime CretaedAt { get; set; } = DateTime.UtcNow;
    public List<TenantWashroomBooking> TenantWashroomBookings { get; set; } = new();

}