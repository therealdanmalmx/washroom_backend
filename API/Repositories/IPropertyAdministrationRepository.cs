using Core.Models;

namespace API.Repositories;

public interface IPropertyAdministrationRepository
{
    List<PropertyAdministration> GetAllPropertyAdministrations();
    List<PropertyAdministration> GetPropertyAdministration(Guid id);
    List<PropertyAdministration> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration);
}