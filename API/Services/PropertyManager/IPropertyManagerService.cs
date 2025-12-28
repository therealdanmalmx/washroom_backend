using Core.DTOs.PropertyManager;

namespace API.Services.PropertyManager;

public interface IPropertyManagerService
{
    List<PropertyManagerGetAllDto> GetAllPropertyManagers();
    List<PropertyManagerGetAllDto> CreatePropertyManager(PropertyManagerCreateDto newPropertyManager);
    PropertyManagerGetAllDto GetPropertyManagerById(int id);
    List<PropertyManagerGetAllDto>? UpdatePropertyManager(int id, PropertyManagerUpdateDto updatePropertyManager);

    List<PropertyManagerGetAllDto>? DeletePropertyManager(int id);




}