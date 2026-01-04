using Core.DTOs.PropertyManager;

namespace API.Services.PropertyManager;

public interface IPropertyManagerService
{
    Task<List<PropertyManagerGetAllDto>> GetAllPropertyManagers();
    Task<List<PropertyManagerGetAllDto>> CreatePropertyManager(PropertyManagerCreateDto newPropertyManager);
    Task<PropertyManagerGetAllDto>? GetPropertyManagerById(Guid id);
    Task<List<PropertyManagerGetAllDto>>? UpdatePropertyManager(Guid id, PropertyManagerUpdateDto updatePropertyManager);
    Task<List<PropertyManagerGetAllDto>>? DeletePropertyManager(Guid id);




}