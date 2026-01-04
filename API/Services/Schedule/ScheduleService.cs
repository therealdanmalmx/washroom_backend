using API.Repositories.ScheduleRepository;
using Core.DTOs.Schedule;
using Mapster;

namespace API.Services.Schedule;

public class ScheduleService : IScheduleService
{
    private readonly IScheduleRepository _scheduleRepository;

    public ScheduleService(IScheduleRepository scheduleRepository)
    {
        _scheduleRepository = scheduleRepository;
    }

    public async Task<List<ScheduleGetAllDto>> GetAllSchedules()
    {
        var result = await _scheduleRepository.GetAllSchedules();
        return result.Adapt<List<ScheduleGetAllDto>>(); 
    }

    public async Task<List<ScheduleGetAllDto>> CreateSchedule(ScheduleCreateDto newSchedule)
    {
        var newScheduleEntry = newSchedule.Adapt<Core.Models.Schedule>();
        var result = await _scheduleRepository.CreateSchedules(newScheduleEntry);
        return result.Adapt<List<ScheduleGetAllDto>>();
    }

    public async Task<ScheduleGetAllDto>? GetScheduleById(int id)
    {
        var result = await _scheduleRepository.GetScheduleById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<ScheduleGetAllDto>();
    }

    public async Task<List<ScheduleGetAllDto>> UpdateSchedules(int id, ScheduleUpdateDto updateSchedule)
    {
        var scheduleToUpdate = updateSchedule.Adapt<Core.Models.Schedule>();
        var result = await _scheduleRepository.UpdateSchedule(id, scheduleToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<ScheduleGetAllDto>>();
    }

    public async Task<List<ScheduleGetAllDto>> DeleteSchedules(int id)
    {
        var  scheduleToDelete = await _scheduleRepository.DeleteSchedule(id);
        if (scheduleToDelete == null)
        {
            return null;
        }
        return scheduleToDelete.Adapt<List<ScheduleGetAllDto>>();
    }
}