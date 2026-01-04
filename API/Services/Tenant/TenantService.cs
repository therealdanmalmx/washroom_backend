using API.Repositories;
using Core.DTOs.Tenant;
using Mapster;

namespace API.Services.Tenant;

public class TenantService : ITenantService
{
    private readonly ITenantRepository _tenantRepository;

    public TenantService(ITenantRepository tenantRepository)
    {
        _tenantRepository = tenantRepository;
    }

    public async Task<List<TenantGetAllDto>> GetAllTenants()
    {
        var result = await _tenantRepository.GetAllTenant();
        return result.Adapt<List<TenantGetAllDto>>();
    }

    public async Task<List<TenantGetAllDto>> CreateTenant(TenantCreateDto newTenant)
    {
        var newTentantEntry = newTenant.Adapt<Core.Models.Tenant>();
        var result = await _tenantRepository.CreateTenant(newTentantEntry);
        return result.Adapt<List<TenantGetAllDto>>();
    }

    public async Task<TenantGetAllDto>? GetTenantById(int id)
    {
        var result = await _tenantRepository.GetTenantById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<TenantGetAllDto>();
    }

    public async Task<List<TenantGetAllDto>>? UpdateTenant(int id, TenantUpdateDto updatedTenant)
    {
        var tenantToUpdate = updatedTenant.Adapt<Core.Models.Tenant>();
        var result = await _tenantRepository.UpdateTenant(id, tenantToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantGetAllDto>>();
    }

    public async Task<List<TenantGetAllDto>>? DeleteTenant(int id)
    {
        var result = await _tenantRepository.DeleteTenant(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantGetAllDto>>();
    }
}