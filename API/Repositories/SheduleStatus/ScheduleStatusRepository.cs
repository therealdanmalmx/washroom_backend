using Core.Models;

namespace API.Repositories.SheduleStatus;

public class ScheduleStatusRepository : IScheduleStatusRepository
{
    List<ScheduleStatus> _scheduleStatuses = 
    [
        new ScheduleStatus()
        {
            Id = 1,
            Description = "Available",
        },
        new ScheduleStatus()
        {
            Id = 2,
            Description = "Booked",
        }
    ];
    public List<ScheduleStatus> GetAllScheduleStatus()
    {
        return _scheduleStatuses;
    }

    public List<ScheduleStatus> CreateScheduleStatus(ScheduleStatus newScheduleStatus)
    {
        _scheduleStatuses.Add(newScheduleStatus);
        return _scheduleStatuses;
    }

    public ScheduleStatus? GetScheduleStatusById(int id)
    {
        var singleScheduleStatus = _scheduleStatuses.FirstOrDefault(s => s.Id == id);
        if (singleScheduleStatus == null)
        {
            return null;
        }
        return singleScheduleStatus;
    }

    public List<ScheduleStatus>? UpdateScheduleStatus(int id, ScheduleStatus updateScheduleStatus)
    {
        var scheduleStatusToUpdateIndex = _scheduleStatuses.FindIndex(s => s.Id == id);
        if (scheduleStatusToUpdateIndex == -1)
        {
            return null;
        }
        _scheduleStatuses[scheduleStatusToUpdateIndex] = updateScheduleStatus;
        return _scheduleStatuses;
    }

    public List<ScheduleStatus>? DeleteScheduleStatus(int id)
    {
        var scheduleStatusToDelete = _scheduleStatuses.Find(s => s.Id == id);
        if (scheduleStatusToDelete == null)
        {
            return null;
        }
        _scheduleStatuses.Remove(scheduleStatusToDelete);
        return _scheduleStatuses;
    }
}