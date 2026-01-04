using Core.DTOs.Property;

namespace API.Services.Property;

public interface IPropertyService
{
    Task<List<PropertyGetAllDto>> GetAllProperties();
    Task<List<PropertyGetAllDto>> CreateProperty(PropertyCreateDto newProperty);
    Task<PropertyGetAllDto>? GetPropertyById(Guid id);
    Task<List<PropertyGetAllDto>> UpdateProperty(Guid id, PropertyUpdateDto propertyUpdateDto);
    Task<List<PropertyGetAllDto>> DeleteProperty(Guid id);
}