using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.SheduleStatus;

public class ScheduleStatusRepository : IScheduleStatusRepository
{
    private readonly DataContext _dB;
    public ScheduleStatusRepository(DataContext dB)
    {
        _dB = dB;
    }
    
    public async Task<List<ScheduleStatus>> GetAllScheduleStatus()
    {
        return await _dB.ScheduleStatuses.ToListAsync();
    }

    public async Task<List<ScheduleStatus>> CreateScheduleStatus(ScheduleStatus newScheduleStatus)
    {
        _dB.ScheduleStatuses.Add(newScheduleStatus);
        await _dB.SaveChangesAsync();
        return await _dB.ScheduleStatuses.ToListAsync();
    }

    public async Task<ScheduleStatus>? GetScheduleStatusById(Guid id)
    {
        var singleScheduleStatus = await _dB.ScheduleStatuses.FindAsync(id);
        if (singleScheduleStatus == null)
        {
            return null;
        }
        return singleScheduleStatus;
    }

    public async Task<List<ScheduleStatus>>? UpdateScheduleStatus(Guid id, ScheduleStatus updateScheduleStatus)
    {
        var scheduleStatusToUpdate = await _dB.ScheduleStatuses.FindAsync(id);
        if (scheduleStatusToUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(updateScheduleStatus.Description))
        {
            scheduleStatusToUpdate.Description = updateScheduleStatus.Description;
        }

        await _dB.SaveChangesAsync();
        return await _dB.ScheduleStatuses.ToListAsync();
    }

    public async Task<List<ScheduleStatus>>? DeleteScheduleStatus(Guid id)
    {
        var scheduleStatusToDelete = await _dB.ScheduleStatuses.FindAsync(id);
        if (scheduleStatusToDelete == null)
        {
            return null;
        }
        _dB.ScheduleStatuses.Remove(scheduleStatusToDelete);
        await _dB.SaveChangesAsync();
        return await _dB.ScheduleStatuses.ToListAsync();
    }
}