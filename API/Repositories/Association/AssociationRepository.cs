using Core.Models;

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
}