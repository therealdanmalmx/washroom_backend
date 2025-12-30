using API.Repositories;
using Core.DTOs.Property;
using Mapster;

namespace API.Services.Property;

public class PropertyService : IPropertyService
{
    private readonly IPropertyRepository _propertyRepository;

    public PropertyService(IPropertyRepository propertyRepository)
    {
        _propertyRepository = propertyRepository;
    }

    public List<PropertyGetAllDto> GetAllProperties()
    {
        var result = _propertyRepository.GetAllProperties();
        return result.Adapt<List<PropertyGetAllDto>>();
    }

    public List<PropertyGetAllDto>? CreateProperty(PropertyCreateDto newProperty)
    {
        var newPropertyEntry = newProperty.Adapt<Core.Models.Property>();
        var result = _propertyRepository.CreateProperty(newPropertyEntry);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<PropertyGetAllDto>>();
    }

    public PropertyGetAllDto? GetPropertyById(int id)
    {
        var result = _propertyRepository.GetPropertyById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<PropertyGetAllDto>();
    }

    public List<PropertyGetAllDto> UpdateProperty(int id, PropertyUpdateDto propertyUpdateDto)
    {
        var updateProperty = propertyUpdateDto.Adapt<Core.Models.Property>();
        var result = _propertyRepository.UpdateProperty(id, updateProperty);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<PropertyGetAllDto>>();
    }

    public List<PropertyGetAllDto> DeleteProperty(int id)
    {
        var result = _propertyRepository.DeleteProperty(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<PropertyGetAllDto>>();
    }
}