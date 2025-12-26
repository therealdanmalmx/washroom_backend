using Core.Models;

namespace API.Repositories;

public interface IPropertyAdministrationRepository
{
    List<PropertyAdministration> GetAllPropertyAdministrations();
    PropertyAdministration GetPropertyAdministration(int id);
    List<PropertyAdministration> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration);
    List<PropertyAdministration>? UpdatePropertyAdministration(int id, PropertyAdministration updatePropertyAdministration);
    List<PropertyAdministration> DeletePropertyAdministration(int id);
}
