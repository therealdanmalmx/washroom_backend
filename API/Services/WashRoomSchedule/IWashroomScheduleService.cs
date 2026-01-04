using Core.DTOs.WasroomSchedule;

namespace API.Services.WashRoomSchedule;

public interface IWashroomScheduleService
{
    Task<List<WashRoomScheduleGetAllDto>> GetAllWashRoomSchedules();
    Task<List<WashRoomScheduleGetAllDto>> CreateWashRoomSchedules(WashRoomScheduleCreateDto newWashRoomSchedule);
    Task<WashRoomScheduleGetAllDto>? GetWashRoomScheduleById(int id);
    Task<List<WashRoomScheduleGetAllDto>>? UpdateWashRoomSchedules(int id, WashRoomScheduleUpdateDto updateWashRoomSchedule);
    Task<List<WashRoomScheduleGetAllDto>>? DeleteWashRoomSchedules(int id);
    
}