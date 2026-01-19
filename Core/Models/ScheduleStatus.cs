namespace Core.Models;

public class ScheduleStatus
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Schedule> Schedules { get; set; } = new();
}