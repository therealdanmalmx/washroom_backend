using Core.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Repositories;

public class AssociationRepository : IAssociationRepository
{
    private List<Association> _associations =
    [
        new Association
        {
            Id = 1,
            Name = "BRF Kråkan",
        },
        new Association
        {
            Id = 2,
            Name = "BRF Kullerstenen"
        }
    ];
    
    public List<Association> GetAllAssociations()
    {
        return _associations;
    }

    public List<Association> CreateAssociation(Association association)
    {
        _associations.Add(association);
        return _associations;
    }

    public Association? GetAssociationById(int id)
    {
        var singleAssociation = _associations.FirstOrDefault(a => a.Id == id);
        if (singleAssociation == null)
        {
            return null;
        }
        return singleAssociation;
        
    }

    public List<Association> UpdateAssociation(int id, Association association)
    {
        var associationToUpdateIndex = _associations.FindIndex(a => a.Id == id);
        if (associationToUpdateIndex == -1)
        {
            return null;
        }
        _associations[associationToUpdateIndex] =  association;
        return _associations;

    }

    public List<Association>? DeleteAssociation(int id)
    {
        var associationToDelete =  _associations.FirstOrDefault(a => a.Id == id);
        if (associationToDelete == null)
        {
            return null;
        }
        _associations.Remove(associationToDelete);
        return _associations;
    }
}