using Core.Models;

namespace API.Repositories
{
    public interface IPropertyManagerRepository
    {
        List<PropertyManager> GetAllPropertyManagers();
        List<PropertyManager> CreatePropertyManager(PropertyManager newPropertyManager);
        PropertyManager GetPropertyManagerById(int id);
        List<PropertyManager>? DeletePropertyManager(int id);

    }
    
}

