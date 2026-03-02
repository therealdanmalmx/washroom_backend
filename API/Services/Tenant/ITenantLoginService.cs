using Core.DTOs.Tenant;

namespace API.Services.Tenant;

public interface ITenantLoginService
{
    Task<TenantLoginResponse> Login(TenantLoginRequest request);
}