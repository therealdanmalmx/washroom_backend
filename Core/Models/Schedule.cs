namespace Core.Models;

public class Schedule
{
    public int Id { get; set; }
    public string Description { get; set; } =  string.Empty;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int ScheduleStatusId { get; set; }
    public DateTime CreatedAt { get; set; } =  DateTime.Now;
}