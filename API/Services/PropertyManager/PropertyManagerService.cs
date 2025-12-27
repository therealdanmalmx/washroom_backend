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
}