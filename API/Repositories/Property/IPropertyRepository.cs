using Core.Models;

namespace API.Repositories;

public interface IPropertyRepository
{
    List<Property> GetAllProperties();
    List<Property> CreateProperty(Property property);
    Property? GetPropertyById(int id);
    List<Property> UpdateProperty(int id, Property property);
    List<Property> DeleteProperty(int id);
}