using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class WashroomscheduleRepository : IWashoomscheduleRepository
{
    private readonly DataContext _dB;
    public WashroomscheduleRepository(DataContext dB)
    {
        _dB = dB;
    }
    public async Task<List<WashRoomSchedule>> GetAllWashRoomSchedules()
    {
        return await _dB.WashRoomSchedules.ToListAsync();
    }

    public async Task<List<WashRoomSchedule>> CreateWashRoomSchedules(WashRoomSchedule newWashRoomSchedule)
    {
        _dB.WashRoomSchedules.Add(newWashRoomSchedule);
        await _dB.SaveChangesAsync();
        return await _dB.WashRoomSchedules.ToListAsync();
    }

    public async Task<WashRoomSchedule>? GetWashRoomScheduleById(Guid id)
    {
        var result = await _dB.WashRoomSchedules.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public async Task<List<WashRoomSchedule>>? UpdateWashRoomSchedule(Guid id, WashRoomSchedule updateWashRoomSchedule)
    {
        var washRoomScheduleToUpdate = await _dB.WashRoomSchedules.FindAsync(id);
        if (washRoomScheduleToUpdate == null)
        {
            return null;
        }
        washRoomScheduleToUpdate.ScheduleId = updateWashRoomSchedule.ScheduleId;
        washRoomScheduleToUpdate.WashRoomId = updateWashRoomSchedule.WashRoomId;
        
        await _dB.SaveChangesAsync();
        return await _dB.WashRoomSchedules.ToListAsync();
    }

    public async Task<List<WashRoomSchedule>>? DeleteWashRoomSchedule(Guid id)
    {
        var washRoomScheduleToDelte = await _dB.WashRoomSchedules.FindAsync(id);
        if (washRoomScheduleToDelte == null)
        {
            return null;
        }
        
        _dB.WashRoomSchedules.Remove(washRoomScheduleToDelte);
        await _dB.SaveChangesAsync();
        return await _dB.WashRoomSchedules.ToListAsync();
    }
}