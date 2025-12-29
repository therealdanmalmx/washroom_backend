using Core.DTOs.Association;

namespace API.Services.Association;

public interface IAssociationService
{
    List<AssociationGetAllDto> GetAllAssociations();
}