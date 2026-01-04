using Core.Models;
namespace API.Repositories;
public interface ITenantRepository
{
    Task<List<Tenant>> GetAllTenant();
    Task<List<Tenant>> CreateTenant(Tenant tenant);
    Task<Tenant>? GetTenantById(int id);
    Task<List<Tenant>>? UpdateTenant(int id, Tenant newTenant);
    Task<List<Tenant>>? DeleteTenant(int id);
}