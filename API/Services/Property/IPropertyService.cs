using Core.DTOs.Property;

namespace API.Services.Property;

public interface IPropertyService
{
    Task<List<PropertyGetAllDto>> GetAllProperties();
    Task<List<PropertyGetAllDto>> CreateProperty(PropertyCreateDto newProperty);
    Task<PropertyGetAllDto>? GetPropertyById(int id);
    Task<List<PropertyGetAllDto>> UpdateProperty(int id, PropertyUpdateDto propertyUpdateDto);
    Task<List<PropertyGetAllDto>> DeleteProperty(int id);
}