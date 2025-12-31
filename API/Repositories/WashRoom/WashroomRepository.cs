using Core.Models;

namespace API.Repositories;

public class WashroomRepository : IWashroomRepository
{
    private List<WashRoom> _washRooms =
    [
        new WashRoom()
        {
            Id = 1,
            Name = "Tvättrum 1",
            PropertyId = 1
        },
        new WashRoom()
        {
            Id = 2,
            Name = "Tvättrum 2",
            PropertyId = 2
        }
    ];
    
    public List<WashRoom> GetAllWashrooms()
    {
        return _washRooms;
    }

    public List<WashRoom> CrateWashrooms(WashRoom newWashroom)
    {
        _washRooms.Add(newWashroom);
        return _washRooms;
    }

    public WashRoom? GetWashroomById(int id)
    {
        var result = _washRooms.FirstOrDefault(w => w.Id == id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public List<WashRoom>? UpdateWashroom(int id, WashRoom updateWashroom)
    {
        var washroomTouUpdateIndex = _washRooms.FindIndex(w => w.Id == id);
        if (washroomTouUpdateIndex == -1)
        {
            return null;
        }
        _washRooms[washroomTouUpdateIndex] = updateWashroom;
        return _washRooms;
    }

    public List<WashRoom>? DeleteWashroom(int id)
    {
        var result = _washRooms.FirstOrDefault(w => w.Id == id);
        if (result == null)
        {
            return null;
        }
        _washRooms.Remove(result);
        return _washRooms;
    }
}