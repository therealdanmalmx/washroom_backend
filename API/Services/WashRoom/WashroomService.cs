using API.Repositories;
using Core.DTOs.WashRoom;
using Mapster;

namespace API.Services.WashRoom;

public class WashroomService : IWashroomService
{
    private readonly IWashroomRepository _washroomRepository;

    public WashroomService(IWashroomRepository washroomRepository)
    {
        _washroomRepository = washroomRepository;
    }

    public async Task<List<WashRoomGetAllDto>> GetAllWashRooms()
    {
        var result = await _washroomRepository.GetAllWashrooms();
        return result.Adapt<List<WashRoomGetAllDto>>();
    }

    public async Task<List<WashRoomGetAllDto>> CreateWashRoom(WashRoomCreateDto newWashroom)
    {
        var newWashroomEntry =  newWashroom.Adapt<Core.Models.WashRoom>();
        var result = await _washroomRepository.CreateWashrooms(newWashroomEntry);
        return result.Adapt<List<WashRoomGetAllDto>>();
    }

    public async Task<WashRoomGetAllDto>? GetWashRoomById(Guid id)
    {
        var singleWashroom = await _washroomRepository.GetWashroomById(id);
        if (singleWashroom == null)
        {
            return null;
        }
        return singleWashroom.Adapt<WashRoomGetAllDto>();
    }

    public async Task<List<WashRoomGetAllDto>>? UpdateWashRoom(Guid id, WashRoomUpdateDto updateWashroom)
    {
        var washroomToUpdate = updateWashroom.Adapt<Core.Models.WashRoom>();
        var result =  await _washroomRepository.UpdateWashroom(id, washroomToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<WashRoomGetAllDto>>();
    }

    public async Task<List<WashRoomGetAllDto>>? DeleteWashRoom(Guid id)
    {
        var washroomToDelete = await _washroomRepository.DeleteWashroom(id);
        if (washroomToDelete == null)
        {
            return null;
        }
        return washroomToDelete.Adapt<List<WashRoomGetAllDto>>();
    }
}