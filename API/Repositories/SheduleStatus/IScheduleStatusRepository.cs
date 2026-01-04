using Core.Models;

namespace API.Repositories.SheduleStatus;

public interface IScheduleStatusRepository
{
    Task<List<ScheduleStatus>> GetAllScheduleStatus();
    Task<List<ScheduleStatus>> CreateScheduleStatus(ScheduleStatus newScheduleStatus);
    Task<ScheduleStatus>? GetScheduleStatusById(Guid id);
    Task<List<ScheduleStatus>>? UpdateScheduleStatus(Guid id,ScheduleStatus updateScheduleStatus);
    Task<List<ScheduleStatus>>? DeleteScheduleStatus(Guid id);
}