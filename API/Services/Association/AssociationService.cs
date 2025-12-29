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

    public List<AssociationCreateDto> CreateAssociation(AssociationCreateDto newAssociation)
    {
        var newAssociationEntry = newAssociation.Adapt<Core.Models.Association>();
        var result = _associationRepository.CreateAssociation(newAssociationEntry);

        if (result == null)
        {
            return null;
        }
        return  result.Adapt<List<AssociationCreateDto>>(); 
    }

    public AssociationCreateDto? GetAssociationById(int id)
    {
       var singleAssociation =  _associationRepository.GetAssociationById(id);
       if (singleAssociation == null)
       {
           return null;
       }
       return singleAssociation.Adapt<AssociationCreateDto>();
    }

    public List<AssociationUpdateDto> UpdateAssociation(int id, AssociationUpdateDto association)
    {
        var associationToUpdate = association.Adapt<Core.Models.Association>();
        var result = _associationRepository.UpdateAssociation(id, associationToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationUpdateDto>>();
        
    }

    public List<AssociationGetAllDto>? DeleteAssociation(int id)
    {
        var result = _associationRepository.DeleteAssociation(id);

        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationGetAllDto>>();
        
    }
}