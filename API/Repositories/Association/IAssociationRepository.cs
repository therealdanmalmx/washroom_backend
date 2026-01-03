using Core.Models;

namespace API.Repositories;

public interface IAssociationRepository
{
    Task<List<Association>> GetAllAssociations();
    Task<List<Association>> CreateAssociation(Association association);
    Task<Association>? GetAssociationById(int id);
    Task<List<Association>>? UpdateAssociation(int id, Association association);
    Task<List<Association>>? DeleteAssociation(int id);
}