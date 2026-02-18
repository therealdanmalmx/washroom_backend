using Microsoft.AspNetCore.Identity;

namespace Core.DTOs.Tenant;

public class TenantUpdateDto : IdentityUser
{
    public Guid ApartmentId { get; set; }

}