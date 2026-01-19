namespace Core.Models;

public class Schedule
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Description { get; set; } =  string.Empty;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public Guid ScheduleStatusId { get; set; }
    public ScheduleStatus ScheduleStatus { get; set; } = new();
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
    public List<WashRoomSchedule> WashRoomSchedules { get; set; } = new();
}