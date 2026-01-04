using Core.DTOs.AssociationManager;

namespace API.Services.AssociationManager;

public interface IAssociationManagerService
{
    Task<List<AssociationManagerGetAllDto>> GetAllAssociationManagers();
    Task<List<AssociationManagerCreateDto>> CreateAssociationManager(AssociationManagerCreateDto newAssociationManager);
    Task<AssociationManagerGetAllDto>? GetAssociationManagerById(int id);
    Task<List<AssociationManagerGetAllDto>>? UpdateAssociationManager(int id, AssociationManagerUpdateDto updateAssociationManager);
    Task<List<AssociationManagerGetAllDto>>? DeleteAssociationManager(int id);
}