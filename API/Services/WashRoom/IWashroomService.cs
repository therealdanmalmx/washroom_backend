using Core.DTOs.WashRoom;

namespace API.Services.WashRoom;

public interface IWashroomService
{
    Task<List<WashRoomGetAllDto>>  GetAllWashRooms();
    Task<List<WashRoomGetAllDto>> CreateWashRoom(WashRoomCreateDto newWashroom);
    Task<WashRoomGetAllDto>? GetWashRoomById(Guid id);
    Task<List<WashRoomGetAllDto>>? UpdateWashRoom(Guid id, WashRoomUpdateDto updateWashroom);
    Task<List<WashRoomGetAllDto>>? DeleteWashRoom(Guid id);
}