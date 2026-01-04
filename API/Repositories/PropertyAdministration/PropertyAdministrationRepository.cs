using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class PropertyAdministrationRepository : IPropertyAdministrationRepository
{
    private readonly DataContext _dB;
    
    public PropertyAdministrationRepository(DataContext dB)
    {
        _dB = dB;
    }
    
    public async Task<List<PropertyAdministration>> GetAllPropertyAdministrations()
    {
        return await _dB.PropertyAdministrations.ToListAsync();
    }

    public async Task<PropertyAdministration> GetPropertyAdministration(int id)
    {
        var singlePropertyAdministration = await _dB.PropertyAdministrations.FindAsync(id);
        if (singlePropertyAdministration == null)
        {
            return null;
        }

        return singlePropertyAdministration;
    }

    public async Task<List<PropertyAdministration>> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration)
    {
        _dB.PropertyAdministrations.Add(newPropertyAdministration);
        await _dB.SaveChangesAsync();
        return await _dB.PropertyAdministrations.ToListAsync();
    }

    public async Task<List<PropertyAdministration>>? UpdatePropertyAdministration(int id, PropertyAdministration updatePropertyAdministration)
    {
        var propertyAdministrationToUpdate = await _dB.PropertyAdministrations.FindAsync(id);
        if (propertyAdministrationToUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(updatePropertyAdministration.Name))
        {
            propertyAdministrationToUpdate.Name = updatePropertyAdministration.Name;
        }
        if (!string.IsNullOrWhiteSpace(updatePropertyAdministration.Logo))
        {
            propertyAdministrationToUpdate.Logo = updatePropertyAdministration.Logo;
        }
        
        await _dB.SaveChangesAsync();
        return await _dB.PropertyAdministrations.ToListAsync();
    }

    public async Task<List<PropertyAdministration>>? DeletePropertyAdministration(int id)
    {
        var propertyAdministrationToDelete = await _dB.PropertyAdministrations.FindAsync(id);
        if (propertyAdministrationToDelete == null)
        {
            return null;
        }
        _dB.PropertyAdministrations.Remove(propertyAdministrationToDelete);
        await _dB.SaveChangesAsync();
        return await _dB.PropertyAdministrations.ToListAsync();
    }
}