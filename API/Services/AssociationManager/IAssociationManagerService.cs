using Core.DTOs.AssociationManager;

namespace API.Services.AssociationManager;

public interface IAssociationManagerService
{
    Task<List<AssociationManagerGetAllDto>> GetAllAssociationManagers();
    Task<List<AssociationManagerCreateDto>> CreateAssociationManager(AssociationManagerCreateDto newAssociationManager);
    Task<AssociationManagerGetAllDto>? GetAssociationManagerById(Guid id);
    Task<List<AssociationManagerGetAllDto>>? UpdateAssociationManager(Guid id, AssociationManagerUpdateDto updateAssociationManager);
    Task<List<AssociationManagerGetAllDto>>? DeleteAssociationManager(Guid id);
}