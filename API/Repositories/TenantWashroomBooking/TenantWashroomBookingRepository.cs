using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class TenantWashroomBookingRepository : ITenantWashroomBookingRepository
{
    private readonly DataContext _dB;
    public TenantWashroomBookingRepository(DataContext dB)
    {
        _dB = dB;
    }
    
    public async Task<List<TenantWashroomBooking>> GetAllTenantWashroomBooking()
    {
        return await _dB.TenantWashroomBookings.ToListAsync();
    }

    public async Task<List<TenantWashroomBooking>> CreateTenantWashroomooking(TenantWashroomBooking tenantWashroomBooking)
    {
        _dB.TenantWashroomBookings.Add(tenantWashroomBooking);
        await _dB.SaveChangesAsync();
        return await _dB.TenantWashroomBookings.ToListAsync();
    }

    public async Task<TenantWashroomBooking>? GetTenantWashroomBookingById(int id)
    {
        var result = await _dB.TenantWashroomBookings.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public async Task<List<TenantWashroomBooking>>? UpdateTenatWashroomBooking(int id, TenantWashroomBooking tenantWashroomBooking)
    {
        var tenantWashroomBookingToUpdate = await _dB.TenantWashroomBookings.FindAsync(id);
        if (tenantWashroomBookingToUpdate == null)
        {
            return null;
        }
        tenantWashroomBookingToUpdate.Date =  tenantWashroomBooking.Date;
        
        await _dB.SaveChangesAsync();
        return await _dB.TenantWashroomBookings.ToListAsync();
    }

    public async Task<List<TenantWashroomBooking>>? DeleteTenantWashroomBookingById(int id)
    {
        var result = await _dB.TenantWashroomBookings.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        _dB.TenantWashroomBookings.Remove(result);
        await _dB.SaveChangesAsync();
        return await _dB.TenantWashroomBookings.ToListAsync();
    }
}