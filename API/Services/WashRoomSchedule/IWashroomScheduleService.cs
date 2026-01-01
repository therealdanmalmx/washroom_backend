using Core.DTOs.WasroomSchedule;

namespace API.Services.WashRoomSchedule;

public interface IWashroomScheduleService
{
    List<WashRoomScheduleGetAllDto> GetAllWashRoomSchedules();
    List<WashRoomScheduleGetAllDto> CreateWashRoomSchedules(WashRoomScheduleCreateDto newWashRoomSchedule);
    WashRoomScheduleGetAllDto? GetWashRoomScheduleById(int id);
    List<WashRoomScheduleGetAllDto>? UpdateWashRoomSchedules(int id, WashRoomScheduleUpdateDto updateWashRoomSchedule);
    List<WashRoomScheduleGetAllDto>? DeleteWashRoomSchedules(int id);
    
}