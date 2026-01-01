using Core.Models;
namespace API.Repositories;

public interface IWashoomscheduleRepository
{
    List<WashRoomSchedule> GetAllWashRoomSchedules();
    List<WashRoomSchedule> CreateWashRoomSchedules(WashRoomSchedule newWashRoomSchedule);
    WashRoomSchedule? GetWashRoomScheduleById(int id);
    List<WashRoomSchedule>? UpdateWashRoomSchedule(int id, WashRoomSchedule updateWashRoomSchedule);
    List<WashRoomSchedule>? DeleteWashRoomSchedule(int id);
    
    
}