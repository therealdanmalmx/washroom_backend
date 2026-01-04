using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class AssociationManagerRepository : IAssociationManagerRepository
{
    private readonly DataContext _dB;
    public AssociationManagerRepository(DataContext dB)
    {
        _dB = dB;
    }


    public async Task<List<AssociationManager>> GetAssociationManagers()
    {
        return await _dB.AssociationManagers.ToListAsync();
    }

    public async Task<List<AssociationManager>> CreateAssociationManager(AssociationManager newAssociationManager)
    {
        _dB.AssociationManagers.Add(newAssociationManager);
        await _dB.SaveChangesAsync();
        return await _dB.AssociationManagers.ToListAsync();
    }
    
    public async Task<AssociationManager>? GetAssociationManagerById(Guid id)
    {
        var singleAssociationManager = await _dB.AssociationManagers.FindAsync(id);
        if (singleAssociationManager == null)
        {
            return null;
        }
        return singleAssociationManager;
    }


    public async Task<List<AssociationManager>>? UpdateAssociationManager(Guid id, AssociationManager updateAssociationManager)
    {
        var associationManagerToUpdate = await _dB.AssociationManagers.FindAsync(id);
        if (associationManagerToUpdate == null)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(updateAssociationManager.Name))
        {
            associationManagerToUpdate.Name = updateAssociationManager.Name;
        }
        if (!string.IsNullOrWhiteSpace(updateAssociationManager.Phone))
        {
            associationManagerToUpdate.Phone = updateAssociationManager.Phone;
        }
        if (!string.IsNullOrWhiteSpace(updateAssociationManager.Email))
        {
            associationManagerToUpdate.Email = updateAssociationManager.Email;
        }
        
        await _dB.SaveChangesAsync();
        return await _dB.AssociationManagers.ToListAsync();
        
    }

    public async Task<List<AssociationManager>>? DeleteAssociationManager(Guid id)
    {
        var associationManagerToDelete = await _dB.AssociationManagers.FindAsync(id);
        if (associationManagerToDelete == null)
        {
            return null;
        }
        _dB.AssociationManagers.Remove(associationManagerToDelete);
        await _dB.SaveChangesAsync();
        return await _dB.AssociationManagers.ToListAsync();
    }
}