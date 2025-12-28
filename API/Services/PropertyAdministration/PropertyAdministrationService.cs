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

    public PropertyAdministrationGetAllDto GetPropertyAdministration(int id)
    {
        var  result = _propertyAdministrationRepository.GetPropertyAdministration(id);
        return result.Adapt<PropertyAdministrationGetAllDto>();
    }

    public List<PropertyAdministrationGetAllDto> CreatePropertyAdministration(PropertyAdministrationCreateDto newPropertyAdministration)
    {
        
        var newEntry = newPropertyAdministration.Adapt<PropertyAdministration>();
        var result = _propertyAdministrationRepository.CreatePropertyAdministration(newEntry);
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }

    public List<PropertyAdministrationGetAllDto>? UpdatePropertyAdministration(int id, PropertyAdministrationUpdateDto updatePropertyAdministration)
    {
        var propertyAdministrationToUpdate = updatePropertyAdministration.Adapt<PropertyAdministration>();
        
        var result = _propertyAdministrationRepository.UpdatePropertyAdministration(id, propertyAdministrationToUpdate);
        if (result is null)
        {
            return null;
        }
        
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }

    public List<PropertyAdministrationGetAllDto>? DeletePropertyAdministration(int id)
    {
        var result = _propertyAdministrationRepository.DeletePropertyAdministration(id);
        if (result is null)
        {
            return null;
        }

        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }
}