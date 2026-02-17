using Microsoft.AspNetCore.Identity;

namespace Core.DTOs.Tenant;

public class TenantCreateDto : IdentityUser
{
    public Guid ApartmentId { get; set; }
}