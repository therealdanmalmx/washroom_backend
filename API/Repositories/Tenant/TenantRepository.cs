using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class TenantRepository : ITenantRepository
{
    private readonly DataContext _dB;
    public TenantRepository(DataContext dB)
    {
        _dB = dB;
    }
    public async Task<List<Tenant>> GetAllTenant()
    {
        return await _dB.Tenants.ToListAsync();
    }

    public async Task<List<Tenant>> CreateTenant(Tenant tenant)
    {
        _dB.Tenants.Add(tenant);
        await _dB.SaveChangesAsync();
        return await _dB.Tenants.ToListAsync();
    }

    public async Task<Tenant>? GetTenantById(Guid id)
    {
        var singleTenant = await _dB.Tenants.FindAsync(id);
        if (singleTenant == null)
        {
            return null;
        }
        return singleTenant;
        
    }
    public async Task<List<Tenant>>? UpdateTenant(Guid id, Tenant updateTenant)
    {
        var tenatUpdate = await _dB.Tenants.FindAsync(id);
        if (tenatUpdate == null)
        {
            return null;
        }
        
        await _dB.SaveChangesAsync();
        return await _dB.Tenants.ToListAsync();
    }
    public async Task<List<Tenant>>? DeleteTenant(Guid id)
    {
        var result = await _dB.Tenants.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        _dB.Tenants.Remove(result);
        await _dB.SaveChangesAsync();
        return await _dB.Tenants.ToListAsync();
    }
}