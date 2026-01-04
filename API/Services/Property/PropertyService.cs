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

    public async Task<List<PropertyGetAllDto>> GetAllProperties()
    {
        var result = await _propertyRepository.GetAllProperties();
        return result.Adapt<List<PropertyGetAllDto>>();
    }

    public async Task<List<PropertyGetAllDto>>? CreateProperty(PropertyCreateDto newProperty)
    {
        var newPropertyEntry = newProperty.Adapt<Core.Models.Property>();
        var result = await _propertyRepository.CreateProperty(newPropertyEntry);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<PropertyGetAllDto>>();
    }

    public async Task<PropertyGetAllDto>? GetPropertyById(int id)
    {
        var result = await _propertyRepository.GetPropertyById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<PropertyGetAllDto>();
    }

    public async Task<List<PropertyGetAllDto>> UpdateProperty(int id, PropertyUpdateDto propertyUpdateDto)
    {
        var updateProperty = propertyUpdateDto.Adapt<Core.Models.Property>();
        var result = await _propertyRepository.UpdateProperty(id, updateProperty);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<PropertyGetAllDto>>();
    }

    public async Task<List<PropertyGetAllDto>> DeleteProperty(int id)
    {
        var result = await _propertyRepository.DeleteProperty(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<PropertyGetAllDto>>();
    }
}