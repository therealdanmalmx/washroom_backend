using Core.DTOs.Tenant;

namespace API.Services.Tenant;

public interface ITenantService
{
    Task<List<TenantGetAllDto>> GetAllTenants();
    Task<List<TenantGetAllDto>> CreateTenant(TenantCreateDto newTenant);
    Task<TenantGetAllDto>? GetTenantById(Guid id);
    Task<List<TenantGetAllDto>> UpdateTenant(Guid id, TenantUpdateDto updatedTenant);
    Task<List<TenantGetAllDto>> DeleteTenant(Guid id);
}