using Core.Models;

namespace API.Repositories.ScheduleRepository;

public interface IScheduleRepository
{
    Task<List<Schedule>> GetAllSchedules();
    Task<List<Schedule>> CreateSchedules(Schedule newSchedule);
    Task<Schedule>? GetScheduleById(Guid id);
    Task<List<Schedule>>? UpdateSchedule(Guid id,Schedule updateSchedule);
    Task<List<Schedule>>? DeleteSchedule(Guid id);
}