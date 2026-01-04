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

    public async Task<List<PropertyAdministrationGetAllDto>> GetAllPropertyAdministrations()
    {
        var result = await _propertyAdministrationRepository.GetAllPropertyAdministrations();
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }

    public async Task<PropertyAdministrationGetAllDto> GetPropertyAdministration(Guid id)
    {
        var  result = await _propertyAdministrationRepository.GetPropertyAdministration(id);
        return result.Adapt<PropertyAdministrationGetAllDto>();
    }

    public async Task<List<PropertyAdministrationGetAllDto>> CreatePropertyAdministration(PropertyAdministrationCreateDto newPropertyAdministration)
    {
        
        var newEntry = newPropertyAdministration.Adapt<PropertyAdministration>();
        var result = await _propertyAdministrationRepository.CreatePropertyAdministration(newEntry);
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }

    public async Task<List<PropertyAdministrationGetAllDto>>? UpdatePropertyAdministration(Guid id, PropertyAdministrationUpdateDto updatePropertyAdministration)
    {
        var propertyAdministrationToUpdate = updatePropertyAdministration.Adapt<PropertyAdministration>();
        
        var result = await _propertyAdministrationRepository.UpdatePropertyAdministration(id, propertyAdministrationToUpdate);
        if (result is null)
        {
            return null;
        }
        
        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }

    public async Task<List<PropertyAdministrationGetAllDto>>? DeletePropertyAdministration(Guid id)
    {
        var result = await _propertyAdministrationRepository.DeletePropertyAdministration(id);
        if (result is null)
        {
            return null;
        }

        return result.Adapt<List<PropertyAdministrationGetAllDto>>();
    }
}