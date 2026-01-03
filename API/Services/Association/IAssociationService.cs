using Core.DTOs.Association;

namespace API.Services.Association;

public interface IAssociationService
{
    Task<List<AssociationGetAllDto>> GetAllAssociations();
    Task<List<AssociationCreateDto>> CreateAssociation(AssociationCreateDto newAssociation);
    Task<AssociationCreateDto>? GetAssociationById(int id);
    Task<List<AssociationUpdateDto>>? UpdateAssociation(int id, AssociationUpdateDto association);
    Task<List<AssociationGetAllDto>>? DeleteAssociation(int id);



}