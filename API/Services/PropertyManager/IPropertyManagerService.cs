using Core.DTOs.PropertyManager;

namespace API.Services.PropertyManager;

public interface IPropertyManagerService
{
    Task<List<PropertyManagerGetAllDto>> GetAllPropertyManagers();
    Task<List<PropertyManagerGetAllDto>> CreatePropertyManager(PropertyManagerCreateDto newPropertyManager);
    Task<PropertyManagerGetAllDto>? GetPropertyManagerById(int id);
    Task<List<PropertyManagerGetAllDto>>? UpdatePropertyManager(int id, PropertyManagerUpdateDto updatePropertyManager);
    Task<List<PropertyManagerGetAllDto>>? DeletePropertyManager(int id);




}