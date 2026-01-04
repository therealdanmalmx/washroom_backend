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


    public async Task<List<AssociationManagerGetAllDto>> GetAllAssociationManagers()
    {
        var result = await _associationManagerRepository.GetAssociationManagers();
        return result.Adapt<List<AssociationManagerGetAllDto>>();
    }

    public async Task<List<AssociationManagerCreateDto>> CreateAssociationManager(AssociationManagerCreateDto newAssociationManager)
    {
        var newAssociationManagerEntry = newAssociationManager.Adapt<Core.Models.AssociationManager>();
        var result = await _associationManagerRepository.CreateAssociationManager(newAssociationManagerEntry);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<AssociationManagerCreateDto>>();
    }

    public async Task<AssociationManagerGetAllDto>? GetAssociationManagerById(Guid id)
    {
        var result = await _associationManagerRepository.GetAssociationManagerById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<AssociationManagerGetAllDto>();
    }

    public async Task<List<AssociationManagerGetAllDto>>? UpdateAssociationManager(Guid id, AssociationManagerUpdateDto updateAssociationManager)
    {
        var associationManagerToUpdate = updateAssociationManager.Adapt<Core.Models.AssociationManager>();
        var result = await _associationManagerRepository.UpdateAssociationManager(id, associationManagerToUpdate);
        if (result == null)
        {
            return null;
        }
        return  result.Adapt<List<AssociationManagerGetAllDto>>();
    }

    public async Task<List<AssociationManagerGetAllDto>>? DeleteAssociationManager(Guid id)
    {
        var resutl = await _associationManagerRepository.DeleteAssociationManager(id);
        if (resutl == null)
        {
            return null;
        }
        return resutl.Adapt<List<AssociationManagerGetAllDto>>();
    }
}