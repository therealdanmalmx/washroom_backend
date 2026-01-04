using API.Repositories.SheduleStatus;
using Core.DTOs.ScheduleStatus;
using Core.Models;
using Mapster;

namespace API.Services;

public class ScheduleStatusService : IScheduleStatusService
{
    private readonly IScheduleStatusRepository _scheduleStatusRepository;

    public ScheduleStatusService(IScheduleStatusRepository scheduleStatusRepository)
    {
        _scheduleStatusRepository = scheduleStatusRepository;
    }

    public async Task<List<ScheduleStatusGetAllDto>> GetAllScheduleStatus()
    {
        var result = await _scheduleStatusRepository.GetAllScheduleStatus();
        return result.Adapt<List<ScheduleStatusGetAllDto>>();
    }

    public async Task<List<ScheduleStatusGetAllDto>> CreateScheduleStatus(ScheduleStatusCreateDto newScheduleStatus)
    {
        var newScheduleStatusEntry = newScheduleStatus.Adapt<ScheduleStatus>();
        var result = await _scheduleStatusRepository.CreateScheduleStatus(newScheduleStatusEntry);
        return result.Adapt<List<ScheduleStatusGetAllDto>>();
    }

    public async Task<ScheduleStatusGetAllDto>? GetScheduleStatusById(int id)
    {
        var result = await _scheduleStatusRepository.GetScheduleStatusById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<ScheduleStatusGetAllDto>();
    }

    public async Task<List<ScheduleStatusGetAllDto>>? UpdateScheduleStatus(int id, ScheduleStatusUpdateDto newScheduleStatus)
    {
        var scheduleStatusUpdate = newScheduleStatus.Adapt<ScheduleStatus>();
        var result = await _scheduleStatusRepository.UpdateScheduleStatus(id, scheduleStatusUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<ScheduleStatusGetAllDto>>();
    }

    public async Task<List<ScheduleStatusGetAllDto>>? DeleteScheduleStatus(int id)
    {
        var scheduleStatusDelete = await _scheduleStatusRepository.DeleteScheduleStatus(id);
        if (scheduleStatusDelete == null)
        {
            return null;
        }
        return scheduleStatusDelete.Adapt<List<ScheduleStatusGetAllDto>>();
    }
}