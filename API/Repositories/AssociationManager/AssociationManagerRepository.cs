using Core.Models;

namespace API.Repositories;

public class AssociationManagerRepository : IAssociationManagerRepository
{
    private List<AssociationManager> _associationManagers =
    [
        new AssociationManager()
        {
            Id = 1,
            Name = "Linda Alfredsson",
            Phone = "0771239876",
            Email =  "linda@gmail.com",
            AssociationId = 1
        },
        new AssociationManager()
        {
            Id = 2,
            Name = "Agneta Bengtsson",
            Phone = "0764556543",
            Email =  "agneta.bengtsson@peab.se",
            AssociationId = 2
        }
    ];
    
    public List<AssociationManager> GetAssociationManagers()
    {
        return  _associationManagers;
    }

    public List<AssociationManager> CreateAssociationManager(AssociationManager newAssociationManager)
    {
        _associationManagers.Add(newAssociationManager);
        return _associationManagers;
    }
    
    public AssociationManager? GetAssociationManagerById(int id)
    {
        var singleAssociationManager = _associationManagers.FirstOrDefault(a => a.Id == id);
        if (singleAssociationManager == null)
        {
            return null;
        }
        return singleAssociationManager;
    }


    public List<AssociationManager>? UpdateAssociationManager(int id, AssociationManager updateAssociationManager)
    {
        var associationManagerToUpdateIndex = _associationManagers.FindIndex(a => a.Id == id);
        if (associationManagerToUpdateIndex == -1)
        {
            return null;
        }

        _associationManagers[associationManagerToUpdateIndex] = updateAssociationManager;
        return _associationManagers;
    }

    public List<AssociationManager>? DeleteAssociationManager(int id)
    {
        var associationManagerToDelete = _associationManagers.FirstOrDefault(a => a.Id == id);
        if (associationManagerToDelete == null)
        {
            return null;
        }
        _associationManagers.Remove(associationManagerToDelete);
        return _associationManagers;
    }
}