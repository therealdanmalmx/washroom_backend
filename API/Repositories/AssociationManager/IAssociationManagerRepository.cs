using Core.Models;

namespace API.Repositories;

public interface IAssociationManagerRepository
{
    Task<List<AssociationManager>> GetAssociationManagers();
    Task<List<AssociationManager>> CreateAssociationManager(AssociationManager newAssociationManager);
    Task<AssociationManager>? GetAssociationManagerById(Guid id);
    Task<List<AssociationManager>>? UpdateAssociationManager(Guid id, AssociationManager updateAssociationManager);
    Task<List<AssociationManager>>? DeleteAssociationManager(Guid id);
}