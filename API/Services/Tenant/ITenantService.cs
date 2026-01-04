using Core.DTOs.Tenant;

namespace API.Services.Tenant;

public interface ITenantService
{
    Task<List<TenantGetAllDto>> GetAllTenants();
    Task<List<TenantGetAllDto>> CreateTenant(TenantCreateDto newTenant);
    Task<TenantGetAllDto>? GetTenantById(int id);
    Task<List<TenantGetAllDto>> UpdateTenant(int id, TenantUpdateDto updatedTenant);
    Task<List<TenantGetAllDto>> DeleteTenant(int id);
}