using Core.Models;

namespace API.Repositories.ScheduleRepository;

public interface IScheduleRepository
{
    List<Schedule> GetAllSchedules();
    List<Schedule> CreateSchedules(Schedule newSchedule);
    Schedule? GetScheduleById(int id);
    List<Schedule>? UpdateSchedule(int id,Schedule updateSchedule);
    List<Schedule>? DeleteSchedule(int id);
}