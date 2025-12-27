using Core.DTOs.PropertyAdministration;
using Core.Models;

namespace API.Services;

public interface IPropertyAdministrationService
{
    List<PropertyAdministrationGetAllDto> GetAllPropertyAdministrations();
    PropertyAdministrationGetAllDto GetPropertyAdministration(int id);
    List<PropertyAdministrationGetAllDto> CreatePropertyAdministration(PropertyAdministrationCreateDto newPropertyAdministration);
    List<PropertyAdministrationGetAllDto>? UpdatePropertyAdministration(int id, PropertyAdministrationUpdateDto updatePropertyAdministration);
    List<PropertyAdministrationGetAllDto>? DeletePropertyAdministration(int id);

}