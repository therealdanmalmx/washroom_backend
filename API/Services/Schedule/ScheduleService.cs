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

    public List<ScheduleGetAllDto> GetAllSchedules()
    {
        var result = _scheduleRepository.GetAllSchedules();
        return result.Adapt<List<ScheduleGetAllDto>>(); 
    }

    public List<ScheduleGetAllDto> CreateSchedule(ScheduleCreateDto newSchedule)
    {
        var newScheduleEntry = newSchedule.Adapt<Core.Models.Schedule>();
        var result = _scheduleRepository.CreateSchedules(newScheduleEntry);
        return result.Adapt<List<ScheduleGetAllDto>>();
    }

    public ScheduleGetAllDto? GetScheduleById(int id)
    {
        var result = _scheduleRepository.GetScheduleById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<ScheduleGetAllDto>();
    }

    public List<ScheduleGetAllDto> UpdateSchedules(int id, ScheduleUpdateDto updateSchedule)
    {
        var scheduleToUpdate = updateSchedule.Adapt<Core.Models.Schedule>();
        var result = _scheduleRepository.UpdateSchedule(id, scheduleToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<ScheduleGetAllDto>>();
    }

    public List<ScheduleGetAllDto> DeleteSchedules(int id)
    {
        var  scheduleToDelete = _scheduleRepository.DeleteSchedule(id);
        if (scheduleToDelete == null)
        {
            return null;
        }
        return scheduleToDelete.Adapt<List<ScheduleGetAllDto>>();
    }
}