using Core.DTOs.Tenant;

namespace API.Services.Tenant;

public interface ITenantService
{
    List<TenantGetAllDto> GetAllTenants();
    List<TenantGetAllDto> CreateTenant(TenantCreateDto newTenant);
    TenantGetAllDto? GetTenantById(int id);
    List<TenantGetAllDto> UpdateTenant(int id, TenantUpdateDto updatedTenant);
    List<TenantGetAllDto> DeleteTenant(int id);
}