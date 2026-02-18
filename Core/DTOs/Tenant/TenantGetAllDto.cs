using Microsoft.AspNetCore.Identity;

namespace Core.DTOs.Tenant;

public class TenantGetAllDto : IdentityUser
{
    public Guid ApartmentId { get; set; }
}