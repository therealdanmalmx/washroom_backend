using Core.DTOs.Association;

namespace API.Services.Association;

public interface IAssociationService
{
    Task<List<AssociationGetAllDto>> GetAllAssociations();
    Task<List<AssociationCreateDto>> CreateAssociation(AssociationCreateDto newAssociation);
    Task<AssociationCreateDto>? GetAssociationById(Guid id);
    Task<List<AssociationUpdateDto>>? UpdateAssociation(Guid id, AssociationUpdateDto association);
    Task<List<AssociationGetAllDto>>? DeleteAssociation(Guid id);



}