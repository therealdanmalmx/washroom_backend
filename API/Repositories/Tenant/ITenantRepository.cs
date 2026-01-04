using Core.Models;
namespace API.Repositories;
public interface ITenantRepository
{
    Task<List<Tenant>> GetAllTenant();
    Task<List<Tenant>> CreateTenant(Tenant tenant);
    Task<Tenant>? GetTenantById(Guid id);
    Task<List<Tenant>>? UpdateTenant(Guid id, Tenant newTenant);
    Task<List<Tenant>>? DeleteTenant(Guid id);
}