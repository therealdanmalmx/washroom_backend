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

    public async Task<List<AssociationGetAllDto>> GetAllAssociations()
    {
        var result = await _associationRepository.GetAllAssociations();
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationGetAllDto>>();
    }

    public async Task<List<AssociationCreateDto>> CreateAssociation(AssociationCreateDto newAssociation)
    {
        var newAssociationEntry = newAssociation.Adapt<Core.Models.Association>();
        var result = await _associationRepository.CreateAssociation(newAssociationEntry);
        newAssociationEntry.CreatedAt = DateTime.UtcNow;
        
        if (result == null)
        {
            return null;
        }
        return  result.Adapt<List<AssociationCreateDto>>(); 
    }

    public async Task<AssociationCreateDto>? GetAssociationById(int id)
    {
       var singleAssociation = await _associationRepository.GetAssociationById(id);
       if (singleAssociation == null)
       {
           return null;
       }
       return singleAssociation.Adapt<AssociationCreateDto>();
    }

    public async Task<List<AssociationUpdateDto>> UpdateAssociation(int id, AssociationUpdateDto association)
    {
        var associationToUpdate = association.Adapt<Core.Models.Association>();
        var result = await _associationRepository.UpdateAssociation(id, associationToUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationUpdateDto>>();
        
    }

    public async Task<List<AssociationGetAllDto>>? DeleteAssociation(int id)
    {
        var result = await _associationRepository.DeleteAssociation(id);

        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationGetAllDto>>();
        
    }
}