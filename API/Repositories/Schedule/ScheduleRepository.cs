using Core.Models;

namespace API.Repositories.ScheduleRepository;

public class ScheduleRepository : IScheduleRepository
{
    private List<Schedule> _schedules =
    [
        new Schedule()
        {
            Id = 1,
            Description = "Tvättid 1",
            StartTime = TimeOnly.Parse("07:00"),
            EndTime = TimeOnly.Parse("12:00"),
            ScheduleStatusId = 1
        },
        new Schedule()
        {
            Id = 2,
            Description = "Tvättid 2",
            StartTime = TimeOnly.Parse("12:00"),
            EndTime = TimeOnly.Parse("16:00"),
            ScheduleStatusId = 2
        }
    ];
    
    public List<Schedule> GetAllSchedules()
    {
        return _schedules;
    }

    public List<Schedule> CreateSchedules(Schedule newSchedule)
    {
        _schedules.Add(newSchedule);
        return _schedules;
    }

    public Schedule? GetScheduleById(int id)
    {
        var singleSchedule = _schedules.FirstOrDefault(s => s.Id == id);
        if (singleSchedule == null)
        {
            return null;
        }
        return singleSchedule;
    }

    public List<Schedule>? UpdateSchedule(int id, Schedule updateSchedule)
    {
        var shceduleToUpdateIndex = _schedules.FindIndex(s => s.Id == id);
        if (shceduleToUpdateIndex == -1)
        {
            return null;
        }
        _schedules[shceduleToUpdateIndex] = updateSchedule;
        return _schedules;
    }

    public List<Schedule>? DeleteSchedule(int id)
    {
        var scheduleToDelete =  _schedules.FirstOrDefault(s => s.Id == id);
        if (scheduleToDelete == null)
        {
            return null;
        }
        _schedules.Remove(scheduleToDelete);
        return _schedules;
    }
}