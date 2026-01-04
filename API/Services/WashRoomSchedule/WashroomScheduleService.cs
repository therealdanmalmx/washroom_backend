using API.Repositories;
using Core.DTOs.WasroomSchedule;
using Mapster;

namespace API.Services.WashRoomSchedule;

public class WashroomScheduleService : IWashroomScheduleService
{
    private readonly IWashoomscheduleRepository _washoomscheduleRepository;

    public WashroomScheduleService(IWashoomscheduleRepository washoomscheduleRepository)
    {
        _washoomscheduleRepository = washoomscheduleRepository;
    }

    public async Task<List<WashRoomScheduleGetAllDto>> GetAllWashRoomSchedules()
    {
        var result = await _washoomscheduleRepository.GetAllWashRoomSchedules();
        return result.Adapt<List<WashRoomScheduleGetAllDto>>();
    }

    public async Task<List<WashRoomScheduleGetAllDto>> CreateWashRoomSchedules(WashRoomScheduleCreateDto newWashRoomSchedule)
    {
        var newWashRoomStatusEntry = newWashRoomSchedule.Adapt<Core.Models.WashRoomSchedule>();
        var result = await _washoomscheduleRepository.CreateWashRoomSchedules(newWashRoomStatusEntry);
        return result.Adapt<List<WashRoomScheduleGetAllDto>>();
    }

    public async Task<WashRoomScheduleGetAllDto>? GetWashRoomScheduleById(int id)
    {
        var result = await _washoomscheduleRepository.GetWashRoomScheduleById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<WashRoomScheduleGetAllDto>();
    }

    public async Task<List<WashRoomScheduleGetAllDto>>? UpdateWashRoomSchedules(int id, WashRoomScheduleUpdateDto updateWashRoomSchedule)
    {
        var washRoomScheduleToUpdate = updateWashRoomSchedule.Adapt<Core.Models.WashRoomSchedule>();
        var result = await _washoomscheduleRepository.UpdateWashRoomSchedule(id, washRoomScheduleToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<WashRoomScheduleGetAllDto>>();
    }

    public async Task<List<WashRoomScheduleGetAllDto>>? DeleteWashRoomSchedules(int id)
    {
        var washRoomScheduleToDelete = await _washoomscheduleRepository.DeleteWashRoomSchedule(id);
        if (washRoomScheduleToDelete == null)
        {
            return null;
        }
        return washRoomScheduleToDelete.Adapt<List<WashRoomScheduleGetAllDto>>();
    }
}