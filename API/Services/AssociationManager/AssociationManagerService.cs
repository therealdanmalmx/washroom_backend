using API.Repositories;
using Core.DTOs.AssociationManager;
using Mapster;

namespace API.Services.AssociationManager;

public class AssociationManagerService : IAssociationManagerService
{
    
    private readonly IAssociationManagerRepository _associationManagerRepository;

    public AssociationManagerService(IAssociationManagerRepository associationManagerRepository)
    {
        _associationManagerRepository = associationManagerRepository;
    }


    public List<AssociationManagerGetAllDto> GetAllAssociationManagers()
    {
        var result = _associationManagerRepository.GetAssociationManagers();
        return result.Adapt<List<AssociationManagerGetAllDto>>();
    }

    public List<AssociationManagerCreateDto> CreateAssociationManager(AssociationManagerCreateDto newAssociationManager)
    {
        var newAssociationManagerEntry = newAssociationManager.Adapt<Core.Models.AssociationManager>();
        var result = _associationManagerRepository.CreateAssociationManager(newAssociationManagerEntry);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationManagerCreateDto>>();
    }

    public AssociationManagerGetAllDto GetAssociationManagerById(int id)
    {
        var result = _associationManagerRepository.GetAssociationManagerById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<AssociationManagerGetAllDto>();
    }

    public List<AssociationManagerGetAllDto> UpdateAssociationManager(int id, AssociationManagerUpdateDto updateAssociationManager)
    {
        var associationManagerToUpdate = updateAssociationManager.Adapt<Core.Models.AssociationManager>();
        var result = _associationManagerRepository.UpdateAssociationManager(id, associationManagerToUpdate);
        if (result == null)
        {
            return null;
        }
        return  result.Adapt<List<AssociationManagerGetAllDto>>();
    }

    public List<AssociationManagerGetAllDto> DeleteAssociationManager(int id)
    {
        var resutl = _associationManagerRepository.DeleteAssociationManager(id);
        if (resutl == null)
        {
            return null;
        }
        return resutl.Adapt<List<AssociationManagerGetAllDto>>();
    }
}