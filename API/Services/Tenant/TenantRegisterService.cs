using Core.DTOs.Tenant;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Tenant;

public class TenantRegisterService : ITenantRegisterService
{
    private readonly UserManager<Core.Models.Tenant> _tenantManager;

    public TenantRegisterService(UserManager<Core.Models.Tenant> tenantManager)
    {
        _tenantManager = tenantManager;
    }

    public async Task<TenantRegistrationResponse> RegisterTenant(TenantRegistrationRequest request)
    {
        var newTenant = new Core.Models.Tenant
        {
            UserName = request.Email, 
            PhoneNumber = request.PhoneNumber, 
            Email = request.Email,
            ApartmentId = request.ApartmentId,
            PropertyId = request.PropertyId,
        };

        var result = await _tenantManager.CreateAsync(newTenant, request.Password);

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description);
            return new TenantRegistrationResponse(false, errors);
        }

        return new TenantRegistrationResponse(true);
    }

    public async Task<List<Core.Models.Tenant>> GetAllTenants()
    {
        if (_tenantManager.Users == null)
        {
            return [];
        }

        return await _tenantManager.Users.ToListAsync();
    }
} 