using Core.DTOs.PropertyManager;

namespace API.Services.PropertyManager;

public interface IPropertyManagerService
{
    List<PropertyManagerGetAllDto> GetAllPropertyManagers();
    
    List<PropertyManagerGetAllDto> CreatePropertyManager(PropertyManagerCreateDto newPropertyManager);


}