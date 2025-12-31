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

    public List<WashRoomGetAllDto> GetAllWashRooms()
    {
        var result = _washroomRepository.GetAllWashrooms();
        return result.Adapt<List<WashRoomGetAllDto>>();
    }

    public List<WashRoomGetAllDto> CreateWashRoom(WashRoomCreateDto newWashroom)
    {
        var newWashroomEntry =  newWashroom.Adapt<Core.Models.WashRoom>();
        var result = _washroomRepository.CrateWashrooms(newWashroomEntry);
        return result.Adapt<List<WashRoomGetAllDto>>();
    }

    public WashRoomGetAllDto? GetWashRoomById(int id)
    {
        var singleWashroom = _washroomRepository.GetWashroomById(id);
        if (singleWashroom == null)
        {
            return null;
        }
        return singleWashroom.Adapt<WashRoomGetAllDto>();
    }

    public List<WashRoomGetAllDto>? UpdateWashRoom(int id, WashRoomUpdateDto updateWashroom)
    {
        var washroomToUpdate = updateWashroom.Adapt<Core.Models.WashRoom>();
        var result =  _washroomRepository.UpdateWashroom(id, washroomToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<WashRoomGetAllDto>>();
    }

    public List<WashRoomGetAllDto>? DeleteWashRoom(int id)
    {
        var washroomToDelete = _washroomRepository.DeleteWashroom(id);
        if (washroomToDelete == null)
        {
            return null;
        }
        return washroomToDelete.Adapt<List<WashRoomGetAllDto>>();
    }
}