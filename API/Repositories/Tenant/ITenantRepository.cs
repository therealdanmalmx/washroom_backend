using Core.Models;

namespace API.Repositories;

public interface ITenantRepository
{
    List<Tenant> GetAllTenant();
    List<Tenant> CreateTenant(Tenant tenant);
    Tenant? GetTenantById(int id);
    List<Tenant>? UpdateTenant(int id, Tenant newTenant);
    List<Tenant>? DeleteTenant(int id);
}