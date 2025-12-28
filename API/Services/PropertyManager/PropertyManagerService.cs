using API.Repositories;
using Core.DTOs.PropertyManager;
using Mapster;

namespace API.Services.PropertyManager;

public class PropertyManagerService : IPropertyManagerService
{
    public readonly IPropertyManagerRepository _propertyManagerRepository;

    public PropertyManagerService(IPropertyManagerRepository propertyManagerRepository)
    {
        _propertyManagerRepository = propertyManagerRepository;
    }

    public List<PropertyManagerGetAllDto> GetAllPropertyManagers()
    {
        var result = _propertyManagerRepository.GetAllPropertyManagers();
        return result.Adapt<List<PropertyManagerGetAllDto>>();;
    }

    public List<PropertyManagerGetAllDto> CreatePropertyManager(PropertyManagerCreateDto newPropertyManager)
    {
        var newEntry = newPropertyManager.Adapt<Core.Models.PropertyManager>();
        var result = _propertyManagerRepository.CreatePropertyManager(newEntry);
        return result.Adapt<List<PropertyManagerGetAllDto>>();
    }

    public PropertyManagerGetAllDto GetPropertyManagerById(int id)
    {
        var result = _propertyManagerRepository.GetPropertyManagerById(id);
        return result.Adapt<PropertyManagerGetAllDto>();
    }

    public List<PropertyManagerGetAllDto>? DeletePropertyManager(int id)
    {
        var result = _propertyManagerRepository.DeletePropertyManager(id);
        if (result is null)
        {
            return null;
        }
        return result.Adapt<List<PropertyManagerGetAllDto>>();
    }
}