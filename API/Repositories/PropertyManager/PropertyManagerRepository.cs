using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class PropertyManagerRepository : IPropertyManagerRepository
    {
        
        private readonly DataContext _dB;
        public PropertyManagerRepository(DataContext dB)
        {
            _dB = dB;
        }

        public async Task<List<PropertyManager>> GetAllPropertyManagers()
        {
            return await _dB.PropertyManagers.ToListAsync();
        }

        public async Task<List<PropertyManager>> CreatePropertyManager(PropertyManager newPropertyManager)
        {
            _dB.PropertyManagers.Add(newPropertyManager);
            await _dB.SaveChangesAsync();
            return await _dB.PropertyManagers.ToListAsync();
        }

        public async Task<PropertyManager>? GetPropertyManagerById(int id)
        {
            var singlePropertyManager = await _dB.PropertyManagers.FindAsync(id);
            if (singlePropertyManager == null)
            {
                return null;
            }

            return singlePropertyManager;
        }

        public async Task<List<PropertyManager>>? UpdatePropertyManager(int id, PropertyManager updatePropertyManager)
        {
            var propertyManagerToUpdate = await _dB.PropertyManagers.FindAsync(id);
            if (propertyManagerToUpdate == null)
            {
                return null;
            }

            if (!string.IsNullOrWhiteSpace(updatePropertyManager.Name))
            {
                propertyManagerToUpdate.Name = updatePropertyManager.Name;
            }
            if (!string.IsNullOrWhiteSpace(updatePropertyManager.Email))
            {
                propertyManagerToUpdate.Email = updatePropertyManager.Email;
            }
            if (!string.IsNullOrWhiteSpace(updatePropertyManager.Phone))
            {
                propertyManagerToUpdate.Phone = updatePropertyManager.Phone;
            }
            if (!string.IsNullOrWhiteSpace(updatePropertyManager.Name))
            {
                propertyManagerToUpdate.Name = updatePropertyManager.Name;
            }
            
            await _dB.SaveChangesAsync();
            return await _dB.PropertyManagers.ToListAsync();
        }

        public async Task<List<PropertyManager>>? DeletePropertyManager(int id)
        {
            var propertyManagerToDelete = await _dB.PropertyManagers.FindAsync(id);
            if (propertyManagerToDelete == null)
            {
                return null;
            }
            _dB.PropertyManagers.Remove(propertyManagerToDelete);
            await _dB.SaveChangesAsync();
            return await _dB.PropertyManagers.ToListAsync();
        }
    }
}