namespace Core.DTOs.WashRoom;

public class WashRoomGetAllDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid PropertyId { get; set; }
}