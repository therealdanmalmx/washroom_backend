using Core.Models;

namespace API.Repositories;

public class WashroomscheduleRepository : IWashoomscheduleRepository
{
    private List<WashRoomSchedule> _washRoomSchedules =
    [
        new WashRoomSchedule()
        {
            Id = 1,
            ScheduleId = 1,
            WashRoomId = 1,
        },
        new WashRoomSchedule()
        {
            Id = 2,
            ScheduleId = 2,
            WashRoomId = 2,
        }
    ];
    public List<WashRoomSchedule> GetAllWashRoomSchedules()
    {
        return _washRoomSchedules;
    }

    public List<WashRoomSchedule> CreateWashRoomSchedules(WashRoomSchedule newWashRoomSchedule)
    {
        _washRoomSchedules.Add(newWashRoomSchedule);
        return _washRoomSchedules;
    }

    public WashRoomSchedule? GetWashRoomScheduleById(int id)
    {
        var result = _washRoomSchedules.FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public List<WashRoomSchedule>? UpdateWashRoomSchedule(int id, WashRoomSchedule updateWashRoomSchedule)
    {
        var washRoomScheduleToUpdateIndex = _washRoomSchedules.FindIndex(x => x.Id == id);
        if (washRoomScheduleToUpdateIndex == -1)
        {
            return null;
        }
        _washRoomSchedules[washRoomScheduleToUpdateIndex] = updateWashRoomSchedule;
        return _washRoomSchedules;
    }

    public List<WashRoomSchedule>? DeleteWashRoomSchedule(int id)
    {
        var washRoomScheduleToDelte =  _washRoomSchedules.FirstOrDefault(x => x.Id == id);
        if (washRoomScheduleToDelte == null)
        {
            return null;
        }
        _washRoomSchedules.Remove(washRoomScheduleToDelte);
        return _washRoomSchedules;
    }
}