using Core.Models;

namespace API.Repositories;

public interface IPropertyRepository
{
    Task<List<Property>> GetAllProperties(); 
    Task<List<Property>> CreateProperty(Property property);
    Task<Property>? GetPropertyById(Guid id);
    Task<List<Property>> UpdateProperty(Guid id, Property property);
    Task<List<Property>> DeleteProperty(Guid id);
}