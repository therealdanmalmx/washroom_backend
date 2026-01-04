using Core.Models;

namespace API.Repositories.SheduleStatus;

public interface IScheduleStatusRepository
{
    Task<List<ScheduleStatus>> GetAllScheduleStatus();
    Task<List<ScheduleStatus>> CreateScheduleStatus(ScheduleStatus newScheduleStatus);
    Task<ScheduleStatus>? GetScheduleStatusById(int id);
    Task<List<ScheduleStatus>>? UpdateScheduleStatus(int id,ScheduleStatus updateScheduleStatus);
    Task<List<ScheduleStatus>>? DeleteScheduleStatus(int id);
}