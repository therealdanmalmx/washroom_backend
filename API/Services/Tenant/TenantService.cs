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

    public List<TenantGetAllDto> GetAllTenants()
    {
        var result = _tenantRepository.GetAllTenant();
        return result.Adapt<List<TenantGetAllDto>>();
    }

    public List<TenantGetAllDto> CreateTenant(TenantCreateDto newTenant)
    {
        var newTentantEntry = newTenant.Adapt<Core.Models.Tenant>();
        var result = _tenantRepository.CreateTenant(newTentantEntry);
        return result.Adapt<List<TenantGetAllDto>>();
    }

    public TenantGetAllDto? GetTenantById(int id)
    {
        var result = _tenantRepository.GetTenantById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<TenantGetAllDto>();
    }

    public List<TenantGetAllDto>? UpdateTenant(int id, TenantUpdateDto updatedTenant)
    {
        var tenantToUpdate = updatedTenant.Adapt<Core.Models.Tenant>();
        var result = _tenantRepository.UpdateTenant(id, tenantToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantGetAllDto>>();
    }

    public List<TenantGetAllDto>? DeleteTenant(int id)
    {
        var result = _tenantRepository.DeleteTenant(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantGetAllDto>>();
    }
}