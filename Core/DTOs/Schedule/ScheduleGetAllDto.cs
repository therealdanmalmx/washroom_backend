namespace Core.DTOs.Schedule;

public class ScheduleGetAllDto
{
    public int Id { get; set; }
    public string Description { get; set; } =  string.Empty;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int ScheduleStatusId { get; set; }
}