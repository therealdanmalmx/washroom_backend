namespace Core.DTOs.Schedule;

public class ScheduleCreateDto
{
    public string Description { get; set; } =  string.Empty;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public Guid ScheduleStatusId { get; set; }
}