using Core.Models;

namespace API.Repositories
{
    public interface IPropertyManagerRepository
    {
        Task<List<PropertyManager>> GetAllPropertyManagers();
        Task<List<PropertyManager>> CreatePropertyManager(PropertyManager newPropertyManager);
        Task<PropertyManager>? GetPropertyManagerById(Guid id);
        Task<List<PropertyManager>>? UpdatePropertyManager(Guid id, PropertyManager updatePropertyManager);
        Task<List<PropertyManager>>? DeletePropertyManager(Guid id);

    }
    
}

