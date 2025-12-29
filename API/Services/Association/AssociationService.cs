using API.Repositories;
using Core.DTOs.Association;
using Mapster;

namespace API.Services.Association;

public class AssociationService : IAssociationService
{
    private readonly IAssociationRepository _associationRepository;

    public AssociationService(IAssociationRepository associationRepository)
    {
        _associationRepository = associationRepository;
    }

    public List<AssociationGetAllDto> GetAllAssociations()
    {
        var result = _associationRepository.GetAllAssociations();
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationGetAllDto>>();
    }
}