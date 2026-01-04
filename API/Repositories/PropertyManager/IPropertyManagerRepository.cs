using Core.Models;

namespace API.Repositories
{
    public interface IPropertyManagerRepository
    {
        Task<List<PropertyManager>> GetAllPropertyManagers();
        Task<List<PropertyManager>> CreatePropertyManager(PropertyManager newPropertyManager);
        Task<PropertyManager>? GetPropertyManagerById(int id);
        Task<List<PropertyManager>>? UpdatePropertyManager(int id, PropertyManager updatePropertyManager);
        Task<List<PropertyManager>>? DeletePropertyManager(int id);

    }
    
}

