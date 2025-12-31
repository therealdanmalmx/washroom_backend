using Core.DTOs.WashRoom;

namespace API.Services.WashRoom;

public interface IWashroomService
{
    List<WashRoomGetAllDto>  GetAllWashRooms();
    List<WashRoomGetAllDto> CreateWashRoom(WashRoomCreateDto newWashroom);
    WashRoomGetAllDto? GetWashRoomById(int id);
    List<WashRoomGetAllDto>? UpdateWashRoom(int id, WashRoomUpdateDto updateWashroom);
    List<WashRoomGetAllDto>? DeleteWashRoom(int id);
}