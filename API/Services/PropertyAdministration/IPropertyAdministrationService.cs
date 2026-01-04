using Core.DTOs.PropertyAdministration;
using Core.Models;

namespace API.Services;

public interface IPropertyAdministrationService
{
    Task<List<PropertyAdministrationGetAllDto>> GetAllPropertyAdministrations();
    Task<List<PropertyAdministrationGetAllDto>> CreatePropertyAdministration(PropertyAdministrationCreateDto newPropertyAdministration);
    Task<PropertyAdministrationGetAllDto>? GetPropertyAdministration(Guid id);
    Task<List<PropertyAdministrationGetAllDto>>? UpdatePropertyAdministration(Guid id, PropertyAdministrationUpdateDto updatePropertyAdministration);
    Task<List<PropertyAdministrationGetAllDto>>? DeletePropertyAdministration(Guid id);

}