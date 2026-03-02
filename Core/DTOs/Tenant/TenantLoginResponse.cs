namespace Core.DTOs.Tenant;

public class TenantLoginResponse
{

    public bool IsSuccessful { get; set; }
    public string? Errors { get; set; } = null;
    public string? Token { get; set; } = null;

    public TenantLoginResponse() { }
    public TenantLoginResponse(bool isSuccessful, string? errors)
    {
        IsSuccessful = isSuccessful;
        Errors = errors;
    }
    public TenantLoginResponse(bool isSuccessful, string? errors, string? token)
    {
        IsSuccessful = isSuccessful;
        Errors = errors;
        Token = token;
    }
}