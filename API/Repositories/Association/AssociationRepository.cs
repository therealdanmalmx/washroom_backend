using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class AssociationRepository : IAssociationRepository
{
    
    private readonly DataContext _dB;
    public AssociationRepository(DataContext dB)
    {
        _dB = dB;
    }
    
    public async Task<List<Association>> GetAllAssociations()
    {
        return await _dB.Associations.ToListAsync();
    }

    public async Task<List<Association>> CreateAssociation(Association association)
    {
        _dB.Associations.AddAsync(association);
        await _dB.SaveChangesAsync();
        return await _dB.Associations.ToListAsync();
    }

    public async Task<Association>? GetAssociationById(int id)
    {
        var singleAssociation = await _dB.Associations.FindAsync(id);
        if (singleAssociation == null)
        {
            return null;
        }
        return singleAssociation;
        
    }

    public async Task<List<Association>>? UpdateAssociation(int id, Association association)
    {
        var associationToUpdate = await _dB.Associations.FindAsync(id);
        if (associationToUpdate != null)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(association.Name))
        {
            associationToUpdate.Name = association.Name;
        }
        await _dB.SaveChangesAsync();
        return await _dB.Associations.ToListAsync();

    }

    public async Task<List<Association>>? DeleteAssociation(int id)
    {
        var associationToDelete = await _dB.Associations.FindAsync(id);
        if (associationToDelete == null)
        {
            return null;
        }
        await _dB.SaveChangesAsync();
        return await _dB.Associations.ToListAsync();
    }
}