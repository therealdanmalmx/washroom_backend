using Core.DTOs.WashRoom;

namespace API.Services.WashRoom;

public interface IWashroomService
{
    Task<List<WashRoomGetAllDto>>  GetAllWashRooms();
    Task<List<WashRoomGetAllDto>> CreateWashRoom(WashRoomCreateDto newWashroom);
    Task<WashRoomGetAllDto>? GetWashRoomById(int id);
    Task<List<WashRoomGetAllDto>>? UpdateWashRoom(int id, WashRoomUpdateDto updateWashroom);
    Task<List<WashRoomGetAllDto>>? DeleteWashRoom(int id);
}