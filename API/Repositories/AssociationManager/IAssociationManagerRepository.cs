using Core.Models;

namespace API.Repositories;

public interface IAssociationManagerRepository
{
    Task<List<AssociationManager>> GetAssociationManagers();
    Task<List<AssociationManager>> CreateAssociationManager(AssociationManager newAssociationManager);
    Task<AssociationManager>? GetAssociationManagerById(int id);
    Task<List<AssociationManager>>? UpdateAssociationManager(int id, AssociationManager updateAssociationManager);
    Task<List<AssociationManager>>? DeleteAssociationManager(int id);
}