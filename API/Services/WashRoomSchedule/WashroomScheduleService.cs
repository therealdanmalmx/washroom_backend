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

    public List<WashRoomScheduleGetAllDto> GetAllWashRoomSchedules()
    {
        var result =  _washoomscheduleRepository.GetAllWashRoomSchedules();
        return result.Adapt<List<WashRoomScheduleGetAllDto>>();
    }

    public List<WashRoomScheduleGetAllDto> CreateWashRoomSchedules(WashRoomScheduleCreateDto newWashRoomSchedule)
    {
        var newWashRoomStatusEntry = newWashRoomSchedule.Adapt<Core.Models.WashRoomSchedule>();
        var result = _washoomscheduleRepository.CreateWashRoomSchedules(newWashRoomStatusEntry);
        return result.Adapt<List<WashRoomScheduleGetAllDto>>();
    }

    public WashRoomScheduleGetAllDto? GetWashRoomScheduleById(int id)
    {
        var result = _washoomscheduleRepository.GetWashRoomScheduleById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<WashRoomScheduleGetAllDto>();
    }

    public List<WashRoomScheduleGetAllDto>? UpdateWashRoomSchedules(int id, WashRoomScheduleUpdateDto updateWashRoomSchedule)
    {
        var washRoomScheduleToUpdate = updateWashRoomSchedule.Adapt<Core.Models.WashRoomSchedule>();
        var result = _washoomscheduleRepository.UpdateWashRoomSchedule(id, washRoomScheduleToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<WashRoomScheduleGetAllDto>>();
    }

    public List<WashRoomScheduleGetAllDto>? DeleteWashRoomSchedules(int id)
    {
        var washRoomScheduleToDelete = _washoomscheduleRepository.DeleteWashRoomSchedule(id);
        if (washRoomScheduleToDelete == null)
        {
            return null;
        }
        return washRoomScheduleToDelete.Adapt<List<WashRoomScheduleGetAllDto>>();
    }
}