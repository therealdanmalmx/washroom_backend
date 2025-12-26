using API.Repositories;
using Core.DTOs.PropertyAdministration;
using Core.Models;
using Mapster;

namespace API.Services;

public class PropertyAdministrationService : IPropertyAdministrationService
{
    private readonly IPropertyAdministrationRepository _propertyAdministrationRepository;

    public PropertyAdministrationService(IPropertyAdministrationRepository propertyAdministrationRepository)
    {
        _propertyAdministrationRepository = propertyAdministrationRepository;
    }

    public List<PropertyAdministrationGetAllDto> GetAllPropertyAdministrations()
    {
        var result = _propertyAdministrationRepository.GetAllPropertyAdministrations();
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }

    public List<PropertyAdministrationGetAllDto> GetPropertyAdministration(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<PropertyAdministrationGetAllDto> CreatePropertyAdministration(PropertyAdministrationCreateDto newPropertyAdministration)
    {
        
        var newEntry = newPropertyAdministration.Adapt<PropertyAdministration>();

        var result = _propertyAdministrationRepository.CreatePropertyAdministration(newEntry);
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }
}