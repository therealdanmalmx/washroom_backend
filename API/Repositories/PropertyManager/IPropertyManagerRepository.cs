using Core.Models;

namespace API.Repositories
{
    public interface IPropertyManagerRepository
    {
        List<PropertyManager> GetAllPropertyManagers();
        List<PropertyManager> CreatePropertyManager(PropertyManager newPropertyManager);
    }
    
}

