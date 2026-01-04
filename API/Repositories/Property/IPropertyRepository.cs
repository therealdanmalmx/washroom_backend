using Core.Models;

namespace API.Repositories;

public interface IPropertyRepository
{
    Task<List<Property>> GetAllProperties(); 
    Task<List<Property>> CreateProperty(Property property);
    Task<Property>? GetPropertyById(int id);
    Task<List<Property>> UpdateProperty(int id, Property property);
    Task<List<Property>> DeleteProperty(int id);
}