using Core.Models;
namespace API.Repositories;

public interface IWashoomscheduleRepository
{
    Task<List<WashRoomSchedule>> GetAllWashRoomSchedules();
    Task<List<WashRoomSchedule>> CreateWashRoomSchedules(WashRoomSchedule newWashRoomSchedule);
    Task<WashRoomSchedule>? GetWashRoomScheduleById(int id);
    Task<List<WashRoomSchedule>>? UpdateWashRoomSchedule(int id, WashRoomSchedule updateWashRoomSchedule);
    Task<List<WashRoomSchedule>>? DeleteWashRoomSchedule(int id);
    
    
}