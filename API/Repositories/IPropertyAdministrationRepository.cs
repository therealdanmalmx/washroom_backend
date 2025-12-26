using Core.Models;

namespace API.Repositories;

public interface IPropertyAdministrationRepository
{
    List<PropertyAdministration> GetPropertyAdministrations();
    List<PropertyAdministration> GetPropertyAdministration(Guid propertyAdministrationId);
    List<PropertyAdministration> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration);
}