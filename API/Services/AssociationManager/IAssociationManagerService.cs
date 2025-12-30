using Core.DTOs.AssociationManager;

namespace API.Services.AssociationManager;

public interface IAssociationManagerService
{
    List<AssociationManagerGetAllDto> GetAllAssociationManagers();
    List<AssociationManagerCreateDto> CreateAssociationManager(AssociationManagerCreateDto newAssociationManager);
    AssociationManagerGetAllDto? GetAssociationManagerById(int id);
    List<AssociationManagerGetAllDto>? UpdateAssociationManager(int id, AssociationManagerUpdateDto updateAssociationManager);
    List<AssociationManagerGetAllDto>? DeleteAssociationManager(int id);
}