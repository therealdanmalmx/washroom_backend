namespace Core.DTOs.Tenant;

public class TenantLoginRequest
{
    public required string UserName { get; set; }
    public required string Password { get; set; }

}