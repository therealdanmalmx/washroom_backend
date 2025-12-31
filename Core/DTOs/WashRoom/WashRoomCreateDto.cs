namespace Core.DTOs.WashRoom;

public class WashRoomCreateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int PropertyId { get; set; }
}