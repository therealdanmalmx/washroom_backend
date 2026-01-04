using Core.Models;

namespace API.Repositories.ScheduleRepository;

public interface IScheduleRepository
{
    Task<List<Schedule>> GetAllSchedules();
    Task<List<Schedule>> CreateSchedules(Schedule newSchedule);
    Task<Schedule>? GetScheduleById(int id);
    Task<List<Schedule>>? UpdateSchedule(int id,Schedule updateSchedule);
    Task<List<Schedule>>? DeleteSchedule(int id);
}