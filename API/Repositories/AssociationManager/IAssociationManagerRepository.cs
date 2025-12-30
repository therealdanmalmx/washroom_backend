using Core.Models;

namespace API.Repositories;

public interface IAssociationManagerRepository
{
    List<AssociationManager> GetAssociationManagers();
    List<AssociationManager> CreateAssociationManager(AssociationManager newAssociationManager);
    AssociationManager? GetAssociationManagerById(int id);
    List<AssociationManager>? UpdateAssociationManager(int id, AssociationManager updateAssociationManager);
    List<AssociationManager>? DeleteAssociationManager(int id);
}