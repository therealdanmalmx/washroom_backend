using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class PropertyRepository : IPropertyRepository
{
    private readonly DataContext _dB;
    
    public PropertyRepository(DataContext dB)
    {
        _dB = dB;
    }
    
    public async Task<List<Property>> GetAllProperties()
    {
        return await _dB.Properties.ToListAsync();
    }

    public async Task<List<Property>> CreateProperty(Property property)
    {
        _dB.Properties.Add(property);
        await _dB.SaveChangesAsync();
        return await _dB.Properties.ToListAsync();
    }

    public async Task<Property>? GetPropertyById(int id)
    {
        var result = await _dB.Properties.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public async Task<List<Property>>? UpdateProperty(int id, Property property)
    {
        var propertyToUpdate = await _dB.Properties.FindAsync(id);
        if (propertyToUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(property.Name))
        {
            propertyToUpdate.Name = property.Name;
        }
        if (!string.IsNullOrWhiteSpace(property.Street))
        {
            propertyToUpdate.Street = property.Street;
        }
        if (!string.IsNullOrWhiteSpace(property.Number))
        {
            propertyToUpdate.Number = property.Number;
        }
        if (!string.IsNullOrWhiteSpace(property.PostalCode))
        {
            propertyToUpdate.PostalCode = property.PostalCode;
        }
        if (!string.IsNullOrWhiteSpace(property.City))
        {
            propertyToUpdate.City = property.City;
        }
        
        await _dB.SaveChangesAsync();
        return await _dB.Properties.ToListAsync();
    }

    public async Task<List<Property>>? DeleteProperty(int id)
    {
        var result = await _dB.Properties.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        _dB.Properties.Remove(result);
        await _dB.SaveChangesAsync();
        return await _dB.Properties.ToListAsync();
    }
}