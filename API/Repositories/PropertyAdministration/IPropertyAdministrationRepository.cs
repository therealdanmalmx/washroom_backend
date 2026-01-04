using Core.Models;

namespace API.Repositories;

public interface IPropertyAdministrationRepository
{
    Task<List<PropertyAdministration>> GetAllPropertyAdministrations();
    Task<List<PropertyAdministration>> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration);
    Task<PropertyAdministration>? GetPropertyAdministration(Guid id);
    Task<List<PropertyAdministration>>? UpdatePropertyAdministration(Guid id, PropertyAdministration updatePropertyAdministration);
    Task<List<PropertyAdministration>>? DeletePropertyAdministration(Guid id);
}
