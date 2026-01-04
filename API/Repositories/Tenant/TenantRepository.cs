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

    public async Task<Tenant>? GetTenantById(int id)
    {
        var singleTenant = await _dB.Tenants.FindAsync(id);
        if (singleTenant == null)
        {
            return null;
        }
        return singleTenant;
        
    }
    public async Task<List<Tenant>>? UpdateTenant(int id, Tenant updateTenant)
    {
        var tenatUpdate = await _dB.Tenants.FindAsync(id);
        if (tenatUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(updateTenant.Name))
        {
            tenatUpdate.Name = updateTenant.Name;
        }
        if (!string.IsNullOrWhiteSpace(updateTenant.Email))
        {
            tenatUpdate.Email = updateTenant.Email;
        }
        if (!string.IsNullOrWhiteSpace(updateTenant.Phone))
        {
            tenatUpdate.Phone = updateTenant.Phone;
        }
        
        await _dB.SaveChangesAsync();
        return await _dB.Tenants.ToListAsync();
    }
    public async Task<List<Tenant>>? DeleteTenant(int id)
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