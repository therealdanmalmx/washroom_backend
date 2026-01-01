namespace Core.Models;

public class WashRoomSchedule
{
    public int Id { get; set; }
    public int ScheduleId { get; set; }
    public int  WashRoomId { get; set; }
    public DateTime CretaedAt { get; set; } = DateTime.Now;
}