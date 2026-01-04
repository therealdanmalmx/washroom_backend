using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class WashroomRepository : IWashroomRepository
{
    private readonly DataContext _dB;
    public WashroomRepository(DataContext dB)
    {
        _dB = dB;
    }

    public async Task<List<WashRoom>> GetAllWashrooms()
    {
        return await _dB.WashRooms.ToListAsync();
    }

    public async Task<List<WashRoom>> CreateWashrooms(WashRoom newWashroom)
    {
        _dB.WashRooms.Add(newWashroom);
        await _dB.SaveChangesAsync();
        return await _dB.WashRooms.ToListAsync();
    }

    public async Task<WashRoom>? GetWashroomById(Guid id)
    {
        var result = await _dB.WashRooms.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public async Task<List<WashRoom>>? UpdateWashroom(Guid id, WashRoom updateWashroom)
    {
        var washroomTouUpdate = await _dB.WashRooms.FindAsync(id);
        if (washroomTouUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrEmpty(updateWashroom.Name))
        {
            washroomTouUpdate.Name = updateWashroom.Name;
        }

        await _dB.SaveChangesAsync();
        return await _dB.WashRooms.ToListAsync();
    }

    public async Task<List<WashRoom>>? DeleteWashroom(Guid id)
    {
        var result = await _dB.WashRooms.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        _dB.WashRooms.Remove(result);
        await _dB.SaveChangesAsync();
        return await _dB.WashRooms.ToListAsync();
    }
}