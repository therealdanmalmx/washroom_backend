using System.Runtime.InteropServices.JavaScript;

namespace Core.DTOs.Tenant;

public class TenantRegistrationResponse
{
    public bool IsSuccessful { get; set; }
    public IEnumerable<string>? Errors { get; set; }

    public TenantRegistrationResponse(bool isSuccessful)
    {
        isSuccessful = IsSuccessful;
    }
    public TenantRegistrationResponse(bool isSuccessful, IEnumerable<string>? errors)
    {
        isSuccessful = IsSuccessful;
        errors = Errors;
    }
}