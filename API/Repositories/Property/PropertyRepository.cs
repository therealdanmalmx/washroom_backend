using Core.Models;

namespace API.Repositories;

public class PropertyRepository : IPropertyRepository
{
    private List<Property> _properties =
    [
        new Property()
        {
            Id = 1,
            Name = "Kråkan 1",
            Street = "Torstensonsgatan",
            Number = "53",
            PostalCode = "503 42",
            City = "Borås",
            PropertyAdministrationId = 1,
            AdssociationManagerId = 1,
        },
        new Property()
        {
            Id = 2,
            Name = "Stuphålet",
            Street = "Silverssonsgatan",
            Number = "10",
            PostalCode = "40566",
            City = "Göteborg",
            PropertyAdministrationId = 2,
            AdssociationManagerId = 2,
        }
    ];
    
    public List<Property> GetAllProperties()
    {
        return _properties;
    }

    public List<Property> CreateProperty(Property property)
    {
        _properties.Add(property);
        return _properties;
    }

    public Property? GetPropertyById(int id)
    {
        var result = _properties.FirstOrDefault(p => p.Id == id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public List<Property>? UpdateProperty(int id, Property property)
    {
        var propertyToUpdateIndex = _properties.FindIndex(p => p.Id == id);
        if (propertyToUpdateIndex == -1)
        {
            return null;
        }
        _properties[propertyToUpdateIndex] = property;
        return _properties;
    }

    public List<Property>? DeleteProperty(int id)
    {
        var result = _properties.FirstOrDefault(p => p.Id == id);
        if (result == null)
        {
            return null;
        }
        _properties.Remove(result);
        return _properties;
    }
}