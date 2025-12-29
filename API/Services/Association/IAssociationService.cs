using Core.DTOs.Association;

namespace API.Services.Association;

public interface IAssociationService
{
    List<AssociationGetAllDto> GetAllAssociations();
    List<AssociationCreateDto> CreateAssociation(AssociationCreateDto newAssociation);
    AssociationCreateDto? GetAssociationById(int id);
    List<AssociationUpdateDto> UpdateAssociation(int id, AssociationUpdateDto association);
    List<AssociationGetAllDto>? DeleteAssociation(int id);



}