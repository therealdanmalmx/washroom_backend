using Core.Models;

namespace API.Repositories;

public class TenantRepository : ITenantRepository
{
    List<Tenant> _tenants =
    [
        new Tenant()
        {
            Id = 1,
            Name = "Mikael Andersson",
            Phone = "0757789977",
            Email = "m.a@comhem.com",
            ApartmentId = 1
        },
        new Tenant()
        {
            Id = 2,
            Name = "Lena Larsson",
            Phone = "0724569875",
            Email = "larson.lena@hotmail.com",
            ApartmentId = 2
        }
    ];
    public List<Tenant> GetAllTenant()
    {
        return _tenants;
    }

    public List<Tenant> CreateTenant(Tenant tenant)
    {
        _tenants.Add(tenant);
        return _tenants;
    }

    public Tenant? GetTenantById(int id)
    {
        var singleTenant = _tenants.Find(t => t.Id == id);
        if (singleTenant == null)
        {
            return null;
        }
        return singleTenant;
        
    }

    public List<Tenant>? UpdateTenant(int id, Tenant updateTenant)
    {
        var tenatUpdateIndex = _tenants.FindIndex(t => t.Id == updateTenant.Id);
        if (tenatUpdateIndex == -1)
        {
            return null;
        }
        _tenants[tenatUpdateIndex] = updateTenant;
        return _tenants;
    }

    public List<Tenant>? DeleteTenant(int id)
    {
        var result = _tenants.FirstOrDefault(t => t.Id == id);
        if (result == null)
        {
            return null;
        }
        _tenants.Remove(result);
        return _tenants;
    }
}