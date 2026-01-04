namespace Core.Models;

public class WashRoomSchedule
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid ScheduleId { get; set; }
    public Guid  WashRoomId { get; set; }
    public DateTime CretaedAt { get; set; } = DateTime.UtcNow;
}