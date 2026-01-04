using Core.DTOs.WasroomSchedule;

namespace API.Services.WashRoomSchedule;

public interface IWashroomScheduleService
{
    Task<List<WashRoomScheduleGetAllDto>> GetAllWashRoomSchedules();
    Task<List<WashRoomScheduleGetAllDto>> CreateWashRoomSchedules(WashRoomScheduleCreateDto newWashRoomSchedule);
    Task<WashRoomScheduleGetAllDto>? GetWashRoomScheduleById(Guid id);
    Task<List<WashRoomScheduleGetAllDto>>? UpdateWashRoomSchedules(Guid id, WashRoomScheduleUpdateDto updateWashRoomSchedule);
    Task<List<WashRoomScheduleGetAllDto>>? DeleteWashRoomSchedules(Guid id);
    
}