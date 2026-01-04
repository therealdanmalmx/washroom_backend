using Core.Models;

namespace API.Repositories;

public interface IAssociationRepository
{
    Task<List<Association>> GetAllAssociations();
    Task<List<Association>> CreateAssociation(Association association);
    Task<Association>? GetAssociationById(Guid id);
    Task<List<Association>>? UpdateAssociation(Guid id, Association association);
    Task<List<Association>>? DeleteAssociation(Guid id);
}