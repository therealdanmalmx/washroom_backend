using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.ScheduleRepository;

public class ScheduleRepository : IScheduleRepository
{
    private readonly DataContext _dB;
    
    public ScheduleRepository(DataContext dB)
    {
        _dB = dB;
    }
    
    public async Task<List<Schedule>> GetAllSchedules()
    {
        return await _dB.Schedules.ToListAsync();
    }

    public async Task<List<Schedule>> CreateSchedules(Schedule newSchedule)
    {
        _dB.Schedules.Add(newSchedule);
        await _dB.SaveChangesAsync();
        return await _dB.Schedules.ToListAsync();
    }

    public async Task<Schedule>? GetScheduleById(Guid id)
    {
        var singleSchedule = await _dB.Schedules.FindAsync(id);
        if (singleSchedule == null)
        {
            return null;
        }
        return singleSchedule;
    }

    public async Task<List<Schedule>>? UpdateSchedule(Guid id, Schedule updateSchedule)
    {
        var shceduleToUpdate = await _dB.Schedules.FindAsync(id);
        if (shceduleToUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrEmpty(updateSchedule.Description))
        {
            shceduleToUpdate.Description = updateSchedule.Description;
        }
        shceduleToUpdate.StartTime =  updateSchedule.StartTime;
        shceduleToUpdate.EndTime =  updateSchedule.EndTime;

        await _dB.SaveChangesAsync();
        return await _dB.Schedules.ToListAsync();
        
    }

    public async Task<List<Schedule>>? DeleteSchedule(Guid id)
    {
        var scheduleToDelete = await _dB.Schedules.FindAsync(id);
        if (scheduleToDelete == null)
        {
            return null;
        }
        
        _dB.Schedules.Remove(scheduleToDelete);
        await _dB.SaveChangesAsync();
        return await _dB.Schedules.ToListAsync();
    }
}