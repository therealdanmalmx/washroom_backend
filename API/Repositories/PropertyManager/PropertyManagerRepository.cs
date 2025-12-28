using Core.Models;

namespace API.Repositories
{
    public class PropertyManagerRepository : IPropertyManagerRepository
    {
        readonly List<PropertyManager> _propertyManagers =
        [
            new PropertyManager
            {
                Id = 1,
                Name = "Niklas Lundqvist",
                Phone = "0704568754",
                Email = "niklas.lundqvist@hsb.com",
                PropertyAdministrationId = 2
            },

            new PropertyManager
            {
                Id = 2,
                Name = "Berit Andersson",
                Phone = "0773424466",
                Email = "berit.lundqvist@riksbyggen.com",
                PropertyAdministrationId = 1
            }
        ];
        
        public List<PropertyManager> GetAllPropertyManagers()
        {
            return _propertyManagers;
        }

        public List<PropertyManager> CreatePropertyManager(PropertyManager newPropertyManager)
        {
            _propertyManagers.Add(newPropertyManager);
           return _propertyManagers;
        }

        public PropertyManager GetPropertyManagerById(int id)
        {
            var singlePropertyManager = _propertyManagers.FirstOrDefault(pm => pm.Id == id);
            if (singlePropertyManager == null)
            {
                return null;
            }

            return singlePropertyManager;
        }

        public List<PropertyManager>? DeletePropertyManager(int id)
        {
            var propertyManagerToDelete = _propertyManagers.FirstOrDefault(pm => pm.Id == id);
            if (propertyManagerToDelete == null)
            {
            return null;
            }
            _propertyManagers.Remove(propertyManagerToDelete);
            return _propertyManagers;
        }
    }
}