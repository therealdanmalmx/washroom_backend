using Core.Models;
namespace API.Repositories;

public interface IWashoomscheduleRepository
{
    Task<List<WashRoomSchedule>> GetAllWashRoomSchedules();
    Task<List<WashRoomSchedule>> CreateWashRoomSchedules(WashRoomSchedule newWashRoomSchedule);
    Task<WashRoomSchedule>? GetWashRoomScheduleById(Guid id);
    Task<List<WashRoomSchedule>>? UpdateWashRoomSchedule(Guid id, WashRoomSchedule updateWashRoomSchedule);
    Task<List<WashRoomSchedule>>? DeleteWashRoomSchedule(Guid id);
    
    
}