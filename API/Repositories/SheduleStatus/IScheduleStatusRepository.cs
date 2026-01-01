using Core.Models;

namespace API.Repositories.SheduleStatus;

public interface IScheduleStatusRepository
{
    List<ScheduleStatus> GetAllScheduleStatus();
    List<ScheduleStatus> CreateScheduleStatus(ScheduleStatus newScheduleStatus);
    ScheduleStatus? GetScheduleStatusById(int id);
    List<ScheduleStatus>? UpdateScheduleStatus(int id,ScheduleStatus updateScheduleStatus);
    List<ScheduleStatus>? DeleteScheduleStatus(int id);
}