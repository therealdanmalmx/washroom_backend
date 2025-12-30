using Core.DTOs.Property;

namespace API.Services.Property;

public interface IPropertyService
{
    List<PropertyGetAllDto> GetAllProperties();
    List<PropertyGetAllDto> CreateProperty(PropertyCreateDto newProperty);
    PropertyGetAllDto? GetPropertyById(int id);
    List<PropertyGetAllDto> UpdateProperty(int id, PropertyUpdateDto propertyUpdateDto);
    List<PropertyGetAllDto> DeleteProperty(int id);
}