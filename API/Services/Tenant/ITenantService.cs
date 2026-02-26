using Core.DTOs.Tenant;

namespace API.Services.Tenant;

public interface ITenantService
{
    Task<TenantRegistrationResponse> RegisterTenant(TenantRegistrationRequest request);
    Task<List<Core.Models.Tenant>> GetAllTenants();
}