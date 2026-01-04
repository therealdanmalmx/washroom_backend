using Core.Models;

namespace API.Repositories;

public interface IPropertyAdministrationRepository
{
    Task<List<PropertyAdministration>> GetAllPropertyAdministrations();
    Task<List<PropertyAdministration>> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration);
    Task<PropertyAdministration>? GetPropertyAdministration(int id);
    Task<List<PropertyAdministration>>? UpdatePropertyAdministration(int id, PropertyAdministration updatePropertyAdministration);
    Task<List<PropertyAdministration>>? DeletePropertyAdministration(int id);
}
