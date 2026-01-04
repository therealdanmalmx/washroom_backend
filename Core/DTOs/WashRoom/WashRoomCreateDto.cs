namespace Core.DTOs.WashRoom;

public class WashRoomCreateDto
{
    public string Name { get; set; } = string.Empty;
    public Guid PropertyId { get; set; }
}